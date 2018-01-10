/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lv.rigacoding.day1;

/**
 *
 * @author IntisN
 */
public class Address {
    public String country;
    public String city;
    public String street;
    public String houseNumber;
    public String apartmentNumber;
    
    public String fullAddress(){
        return country + city + street + houseNumber + apartmentNumber;
    }
}