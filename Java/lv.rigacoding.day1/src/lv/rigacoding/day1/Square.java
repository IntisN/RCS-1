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
public class Square {
    private double lenght;
    private String color;
    
    public Square(double lenght1, String color1){
        this.color = color1;
        this.lenght = lenght1;
    }
    
    public double getArea(){
        return lenght*lenght;
    }
    
    public double getPerimeter(){
        return lenght*4;
    }
    
    public String getColor(){
        return this.color;
    }
}