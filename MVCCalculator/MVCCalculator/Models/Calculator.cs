using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCalculator.Models
{
    
    public class Calculator
    {
      
        [Display(Name = "1st number")]
        [Range(1, 100, ErrorMessage = "Enter the number from 1 to 100.")]
        public double Number1 { get; set; }
       
        [Display(Name = "2nd number")]
        [Range(1, 100, ErrorMessage = "Enter the number from 1 to 100.")]
        public double Number2 { get; set; }
        
        public double Result { get; set; }
        
        [Display(Name = "Operation")]
        public string Operation { get; set; }
        public List<SelectListItem> PossibleOperations { get; set; }

        
        public Calculator()
        {
            PossibleOperations = new List<SelectListItem>();
            PossibleOperations.Add(new SelectListItem { Text = "Add", Value = "+", Selected = true });
            PossibleOperations.Add(new SelectListItem { Text = "Subtract", Value = "-" });
            PossibleOperations.Add(new SelectListItem { Text = "Multiply", Value = "*" });
            PossibleOperations.Add(new SelectListItem { Text = "Divide", Value = "/" });
        }

       
        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    Result = Number1 / Number2;
                    break;
            }
        }
    }
}
