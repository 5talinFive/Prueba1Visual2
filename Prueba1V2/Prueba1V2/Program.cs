using Modelo;
using System;
using System.Collections.Generic;
using Modelo;
using ModeloDB;

namespace Prueba1V2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            payment p_01 = new payment() { amount = "5", payment_date = new DateTime(2022, 1, 25), };
            payment p_02 = new payment() { amount = "6", payment_date = new DateTime(2022, 1, 25), };
            payment p_03 = new payment() { amount = "5", payment_date = new DateTime(2022, 1, 25), };
            payment p_04 = new payment() { amount = "6", payment_date = new DateTime(2022, 1, 25), };
            payment p_05 = new payment() { amount = "5", payment_date = new DateTime(2022, 1, 25), };
            payment p_06 = new payment() { amount = "6", payment_date = new DateTime(2022, 1, 25), };
            payment p_07 = new payment() { amount = "5", payment_date = new DateTime(2022, 1, 25), };
            payment p_08 = new payment() { amount = "6", payment_date = new DateTime(2022, 1, 25), };
            payment p_09 = new payment() { amount = "5", payment_date = new DateTime(2022, 1, 25), };
            payment p_10 = new payment() { amount = "6", payment_date = new DateTime(2022, 1, 25), };

            List<payment> listaPayments = new() { p_01, p_02, p_03, p_04, p_05, p_06, p_07, p_08, p_09, p_10 };


            //Staff
            staff staff1 = new staff()
            {
                first_name = "5talin",
                last_name = "Javier",
                email = "sj@hotmail.com",
                active = true,
                username = "sj",
                password = "123",
                last_update = new DateTime(2022, 1, 20),
                picture = ""
            };

            staff staff2 = new staff()
            {
                first_name = "Carlos",
                last_name = "Andres",
                email = "ca@hotmail.com",
                active = true,
                username = "ca",
                password = "123",
                last_update = new DateTime(2022, 1, 20),
                picture = ""
            };
            staff staff3 = new staff()
            {
                first_name = "Ronberto",
                last_name = "Daniel",
                email = "rd@hotmail.com",
                active = false,
                username = "ca",
                password = "123",
                last_update = new DateTime(2022, 1, 20),
                picture = ""
            };
            staff staff4 = new staff()
            {
                first_name = "Karolina",
                last_name = "Vanesa",
                email = "ca@hotmail.com",
                active = true,
                username = "ca",
                password = "123",
                last_update = new DateTime(2022, 1, 20),
                picture = ""
            };
            staff staff5 = new staff()
            {
                first_name = "Dayana",
                last_name = "Soraya",
                email = "ds@hotmail.com",
                active = true,
                username = "ds",
                password = "123",
                last_update = new DateTime(2022, 1, 20),
                picture = ""
            };
            staff staff6 = new staff()
            {
                first_name = "Ivan",
                last_name = "Juan",
                email = "ij@hotmail.com",
                active = true,
                username = "ij",
                password = "123",
                last_update = new DateTime(2022, 1, 20),
                picture = ""
            };

            List<staff> listaStaff = new() { staff1, staff2, staff3, staff4, staff5, staff6 };



            Repositorio db = new Repositorio();
            db.payment.Add(listaPayments.Add(payment);
            db.SaveChanges();
        }
    }
}

