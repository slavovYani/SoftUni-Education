﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book /*: IComparable<Book>*/
    {
        public Book(string title,int age,params string[] authors)
        {
            Title = title;
            Year = age;
            Authors = authors.ToList();

        }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        //public int CompareTo(Book other)
        //{
        //    int result = this.Year.CompareTo(other.Year);

        //    if (result==0)
        //    {
        //        result = this.Title.CompareTo(other.Title);
        //    }

        //    return result;
        //}

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
