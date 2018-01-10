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
public class LvRigacodingDay1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        /*
        Square kvadrats1 = new Square(5, "red");
        Square kvadrats2 = new Square(20, "green");
        
        System.out.println("Kvadrāta 1 krāsa ir " + kvadrats1.getColor());
        System.out.println("Kvadrāta 2 laukums ir "+ kvadrats2.getArea());
        System.out.println("Kvadrāta 2 perimetrs ir "+ kvadrats2.getPerimeter());
        */
        
        //Adreses informācija
        Address livingPlace = new Address();
        livingPlace.apartmentNumber = "10 ";
        livingPlace.city = "Rīga ";
        livingPlace.country = "Latvija ";
        livingPlace.houseNumber = "152/1 ";
        livingPlace.street = "Augusta Deglava iela ";

        //Nodaļas informācija
        Department departmentInfo = new Department();
        departmentInfo.title = "Iekšējā infrastruktūra";
        departmentInfo.employeeCount = 101;
        departmentInfo.location = livingPlace;
        
        //Darbinieka informācija
        Employee employeeProfile = new Employee();
        employeeProfile.name = "Intis";
        employeeProfile.residence = livingPlace;
        employeeProfile.department = departmentInfo;
        employeeProfile.previousDepartment = "bezdarbniekiem";
        
        System.out.println("Mani sauc " + employeeProfile.name + ", es dzīvoju " + employeeProfile.residence.fullAddress());
        System.out.println("Manis sauc " + employeeProfile.name + ", un es pārgāju uz " + departmentInfo.title + " nodaļu no " + employeeProfile.previousDepartment );
    }
}