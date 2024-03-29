﻿namespace DesignPatterns.ChainOfResponsibilities
{
    // Class holding request details
    class Project
    {
        private int _number;
        private double _amount;
        private string _purpose;

        // Constructor 
        public Project(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}
