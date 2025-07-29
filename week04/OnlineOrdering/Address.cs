using System;
using System.Collections.Generic;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string FullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}