using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSETserver1.Models
{
    public class CustomersMange
    {

        public static Customer[] Customers;     
        public static List<Customer> AddCustomer(List<Customer> customers, List<Customer> newData)
        {           
            var existingDataCount = customers==null?0: customers.Count;
            var newDataCount = newData.Count;
            Customers = new Customer[existingDataCount+ newDataCount];

            if (customers!=null)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    Customers[i] = customers[i];
                }
            }
           
            foreach (var item in newData)
            {
                quicksort(Customers, 0, Customers.Length, item);
            }
            return Customers.ToList();
        }
  
        public static void quicksort(Customer[] arr, int low, int height, Customer customer)
        {
            if (arr[0] == null)
            {
                arr[0] = customer;
                return;
            }

            var pivot = customer;
            var isPivotInsert = false;
            for (int i = low; i < height; i++)
            {
                if (arr[i] != null)
                {
                    int lastNamecomparison = String.Compare(arr[i].lastName, pivot.lastName, comparisonType: StringComparison.OrdinalIgnoreCase);
                    if (lastNamecomparison == 0)
                    {                       
                        int firstNameComparison = String.Compare(arr[i].firstName, pivot.firstName, comparisonType: StringComparison.OrdinalIgnoreCase);

                        if (firstNameComparison > 0)
                        {
                            var temp = arr[i];
                            arr[i] = pivot;
                            for (int z = i+1; z < arr.Length; z++)
                            {
                                if (arr[z]==null)
                                {
                                    arr[z] = temp;
                                    isPivotInsert = true;
                                    break;
                                }
                                var temp1 = arr[z];
                                arr[z] = temp;
                                temp = temp1;
                               
                            }
                            
                           

                        }
                    }
                    else if (lastNamecomparison > 0)
                    {
                        var temp = arr[i];
                        arr[i] = pivot;
                        for (int z = i + 1; z < arr.Length; z++)
                        {
                            if (arr[z] == null)
                            {
                                arr[z] = temp;
                                isPivotInsert = true;
                                break;

                            }
                            var temp1 = arr[z];
                            arr[z] = temp;
                            temp = temp1;

                        }

                    }
                   
                }
                else
                {
                    arr[i] = pivot;
                    break;
                }
                if (isPivotInsert)
                {
                    break;
                }

            }
        }
    }
}