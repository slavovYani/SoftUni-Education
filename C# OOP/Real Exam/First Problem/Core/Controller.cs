
using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private BoothRepository boots;       //readonly
        public Controller()
        {
            boots = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            int currentId = boots.Models.Count + 1;

            boots.AddModel(new Booth(currentId, capacity));

            return string.Format(OutputMessages.NewBoothAdded, new object[] { currentId, capacity });
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            IDelicacy delicacy = null;

            var currentBooth = boots.Models.First(b => b.BoothId == boothId);

            if (currentBooth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == delicacyName) != null)
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            else if (delicacyTypeName == "Gingerbread")
            {
                delicacy = new Gingerbread(delicacyName);
                currentBooth.DelicacyMenu.AddModel(delicacy);
            }
            else if (delicacyTypeName == "Stolen")
            {
                delicacy = new Stolen(delicacyName);
                currentBooth.DelicacyMenu.AddModel(delicacy);

            }
            else
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            return string.Format(OutputMessages.NewDelicacyAdded, new object[] { delicacyTypeName, delicacyName });
        }


        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            ICocktail cocktail = null;

            var currentBooth = boots.Models.First(b => b.BoothId == boothId);

            if (currentBooth.CocktailMenu.Models.FirstOrDefault(d => d.Name == cocktailName && d.Size == size) != null)
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, new object[] { size, cocktailName });
            }
            else if (size != "Small" && size != "Middle" && size != "Large")            // ако не е нито едно от трите ? 
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }

            else if (cocktailTypeName == "Hibernation")
            {
                cocktail = new Hibernation(cocktailName, size);
                currentBooth.CocktailMenu.AddModel(cocktail);
            }
            else if (cocktailTypeName == "MulledWine")
            {
                cocktail = new MulledWine(cocktailName, size);
                currentBooth.CocktailMenu.AddModel(cocktail);

            }
            else
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }

            return string.Format(OutputMessages.NewCocktailAdded, new object[] { size, cocktailName, cocktailTypeName });
        }

        public string ReserveBooth(int countOfPeople)
        {
            var orderedBooths = boots.Models.Where(b => !b.IsReserved && b.Capacity >= countOfPeople)
                .OrderBy(b => b.Capacity).ThenByDescending(b => b.BoothId).ToList();

            var firstBooth = orderedBooths.FirstOrDefault();

            if (firstBooth == null)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            firstBooth.ChangeStatus();          // set it to true ?
            return string.Format(OutputMessages.BoothReservedSuccessfully, new object[] { firstBooth.BoothId, countOfPeople });
        }

        public string TryOrder(int boothId, string order)
        {
            string[] input = order.Split("/").ToArray();
            string itemTypeName = input[0];
            string itemName = input[1];
            int countOfOrderedPieces = int.Parse(input[2]);

            var currentBooth = boots.Models.First(b => b.BoothId == boothId);

            if (itemTypeName != "Hibernation" && itemTypeName != "Gingerbread"
                && itemTypeName != "MulledWine" && itemTypeName != "Stolen")
            {
                return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }
            else if (currentBooth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName) == null &&
              currentBooth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName) == null)
            {
                return string.Format(OutputMessages.NotRecognizedItemName, new object[] { itemTypeName, itemName });
            }
            else
            {

                if (itemTypeName == "Hibernation" || itemTypeName == "MulledWine")
                {
                    string size = input[3];
                    var desiredItem = currentBooth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.Size == size);

                    if (desiredItem == null)
                    {
                        return string.Format(OutputMessages.NotRecognizedItemName, new object[] { size, itemName });
                    }

                    double amountToIncreaseBill = desiredItem.Price * countOfOrderedPieces;
                    currentBooth.UpdateCurrentBill(amountToIncreaseBill);

                    return String.Format(OutputMessages.SuccessfullyOrdered,
                        new object[] { currentBooth.BoothId, countOfOrderedPieces, itemName });
                }
                else
                {

                    var desiredItem = currentBooth.DelicacyMenu.Models.FirstOrDefault(c => c.Name == itemName);

                    if (desiredItem == null)
                    {
                        return string.Format(OutputMessages.NotRecognizedItemName, new object[] { itemTypeName, itemName });
                    }


                    double amountToIncreaseBill = desiredItem.Price * countOfOrderedPieces;
                    currentBooth.UpdateCurrentBill(amountToIncreaseBill);

                    return String.Format(OutputMessages.SuccessfullyOrdered,
                        new object[] { currentBooth.BoothId, countOfOrderedPieces, itemName });
                }
            }

        }
        public string LeaveBooth(int boothId)
        {
            var currentBooth = boots.Models.First(b => b.BoothId == boothId);
            var currentBill = currentBooth.CurrentBill;
            currentBooth.Charge();
            currentBooth.ChangeStatus();          // if here is true ?? will happen FALSE

            var sb = new StringBuilder();

            sb.AppendLine($"Bill {currentBill:F2} lv")
                .AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().TrimEnd();
        }
        public string BoothReport(int boothId)
        {
            var currentBooth = boots.Models.First(b => b.BoothId == boothId);

            //var sb = new StringBuilder();
            //sb.AppendLine($"Booth: {boothId}").AppendLine($"Capacity: {currentBooth.Capacity}")
            //    .AppendLine($"Turnover: {currentBooth.Capacity:F2} lv").AppendLine("-Cocktail menu:");

            //foreach (var item in currentBooth.CocktailMenu.Models)
            //{
            //    sb.AppendLine($"--{item.ToString().TrimEnd()}");
            //}

            //sb.AppendLine($"-Delicacy menu:");

            //foreach (var item in currentBooth.DelicacyMenu.Models)
            //{
            //    sb.AppendLine($"--{item.ToString().TrimEnd()}");

            //}

            return currentBooth.ToString().TrimEnd();
        }



    }
}
