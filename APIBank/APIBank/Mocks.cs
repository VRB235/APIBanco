using APIBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBank
{
    public static class Mocks
    {
        public static List<Person> FillData()
        {
            return new List<Person>
            {
                new Person
                {
                    ID = 1,
                    DocumentID = "V24000001",
                    Email = "juli@gmail.com",
                    Name = "Julianis",
                    LastName = "Caldera",
                    PhoneNumber = "04142031975",
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ID = 1,
                            AmountAvailable = 10000,
                            NameProduct = "CUENTA CORRIENTE",
                            NumberAccount = "10141234556515000001",
                            TypeAccount = "BS",
                            Movements = new List<Movement>
                            {
                                new Movement
                                {
                                    Reference = 1,
                                    Amount = 1000,
                                    Concept =  "Pago de Elextricidad",
                                    DocumentIdBeneficiary = "J151315155",
                                    Type = "DB"
                                }
                                ,
                                new Movement
                                {
                                    Reference = 2,
                                    Amount = 2500,
                                    Concept =  "Pago de Cable",
                                    DocumentIdBeneficiary = "J56565565",
                                    Type = "DB"
                                }
                                ,
                                new Movement
                                {
                                    Reference = 3,
                                    Amount = 5000000,
                                    Concept =  "Transferencia a terceros Banesco",
                                    DocumentIdBeneficiary = "V24000002",
                                    Type = "DB"
                                }
                            }
                        }
                    }
                },
                new Person
                {
                    ID = 2,
                    DocumentID = "V24000002",
                    Email = "andy@gmail.com",
                    Name = "Andy",
                    LastName = "Castro",
                    PhoneNumber = "04145377035",
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ID = 2,
                            AmountAvailable = 1500,
                            NameProduct = "CUENTA CUSTODIA",
                            NumberAccount = "10141234556515000001",
                            TypeAccount = "DLS",
                            Movements = new List<Movement>
                            {
                                new Movement
                                {
                                    Reference = 3,
                                    Amount = 5,
                                    Concept =  "Transferencia a terceros Banesco",
                                    DocumentIdBeneficiary = "V24000001",
                                    Type = "CR"
                                }
                                ,
                                new Movement
                                {
                                    Reference = 5,
                                    Amount = 100,
                                    Concept =  "Operacion de cambio (VENTA)",
                                    DocumentIdBeneficiary = "V24000002",
                                    Type = "DB"
                                }
                                ,
                                new Movement
                                {
                                    Reference = 6,
                                    Amount = 1.5,
                                    Concept =  "Cobro por Mantenimiento",
                                    DocumentIdBeneficiary = "0",
                                    Type = "DB"
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
