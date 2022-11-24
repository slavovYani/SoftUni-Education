﻿namespace P04.Recharge.Models
{
    public abstract class Worker
    {
        private string id;
        private int workingHours;

        protected Worker(string id)
        {
            this.id = id;
        }

        public virtual void Work(int hours) => this.workingHours += hours;
    }
}