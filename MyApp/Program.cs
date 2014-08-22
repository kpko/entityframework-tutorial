﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactsDB ctx = new ContactsDB();
            ctx.Database.Log = (s) =>
            {
                Console.WriteLine(s);
            };

            var contacts = ctx.Contacts.ToList();


            Contact myContact = new Contact();
            myContact.FirstName = "Daisy";
            myContact.LastName = "Duck";

            ctx.Contacts.Add(myContact);
            ctx.SaveChanges();

            contacts = ctx.Contacts.ToList();

        }
    }

    class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class ContactsDB : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
