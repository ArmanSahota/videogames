using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videogames
{
    internal class VideoGame
    {
        string _title;
        string _company;
        int _year;
        bool _isUsed;
        double _price;

        public VideoGame()
        {
            _title = "unassigned";
            _company = "unassigned";
            _year = 0;
            _isUsed = false;
            _price = 0.0;
        }

        public VideoGame(string title, string company)
        {
            _title = title;
            _company = company;
            _year = 0;
            _isUsed = false;
            _price = 0.0;
        }

        public VideoGame(string title, string company, int year, bool isUsed, double price)
        {
            _title = title;
            _company = company;
            _year = year;
            _isUsed = isUsed;
            _price = price;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            string used = _isUsed ? "Used" : "New";
            return $"{_title} - {_company} - {_year} - ${_price:F2} - {used}";
        }
    }
}
