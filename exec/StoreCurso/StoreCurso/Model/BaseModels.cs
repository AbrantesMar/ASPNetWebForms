using System;
using System.Collections.Generic;

namespace StoreCurso.Model
{
    public class BaseModels
    {
        public static List<Item> Items { get; set; }
        public static List<ShopCart> ShopCarts { get; set; }
        public static List<Store> Stores { get; set; }
        public static List<User> Users { get; set; }

        public static void GetItems()
        {
            if (Items != null)
            {
                if (Items.Count > 0)
                    return;
            }


            Items = new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Description = "Oculos de rosto",
                    Name = "Oculos",
                    Price = 1200
                },
                new Item
                {
                    Id = 2,
                    Description = "Bone de sol",
                    Name = "Bone",
                    Price = 1400
                },
                new Item
                {
                    Id = 3,
                    Description = "Computador de trabalho",
                    Name = "Computador",
                    Price = 400
                }
            };
        }

        public static List<Store> GetStores()
        {
            if (Stores != null || Stores.Count > 0)
                return Stores;

            return new List<Store>
            {
                new Store
                {
                    Id = 1,
                    CreationDate = DateTime.Now,
                    Description = "Vendemos roupas",
                    Name = "De Roupas",
                    Valid = true
                },
                new Store
                {
                    Id = 2,
                    CreationDate = DateTime.Now,
                    Description = "vendemos eletronicos",
                    Name = "De eletronicos",
                    Valid = true
                },
                new Store
                {
                    Id = 3,
                    CreationDate = DateTime.Now,
                    Description = "Vedemos alimentos",
                    Name = "De Alimentos",
                    Valid = true
                }
            };
        }

        public static List<User> GetUsers()
        {
            if (Users != null || Users.Count > 0)
                return Users;

            return new List<User>
            {
                new User
                {
                    Id = 1,
                    BirthDate = DateTime.Now,
                    Email = "email@gmail.com",
                    Login = "loginUser",
                    Password = "12345",
                    Name = "Usuario de email",
                    Valid = true
                },
                new User
                {
                    Id = 2,
                    BirthDate = DateTime.Now,
                    Email = "usuario@gmail.com",
                    Login = "usuario",
                    Password = "333333",
                    Name = "Usuario",
                    Valid = true
                },
                new User
                {
                    Id = 1,
                    BirthDate = DateTime.Now,
                    Email = "loja@gmail.com",
                    Login = "loja",
                    Password = "666666",
                    Name = "Nossa loja",
                    Valid = true
                },
                new User
                {
                    Id = 1,
                    BirthDate = DateTime.Now,
                    Email = "banco@gmail.com",
                    Login = "banco",
                    Password = "777777",
                    Name = "Nosso Banco",
                    Valid = false
                }
            };
        }

        public static List<ShopCart> GetShopCarts()
        {
            return null;
        }

        #region ShopCart
        public void CreateShopCart(ShopCart shopCart)
        {
            if (ShopCarts == null)
                ShopCarts = new List<ShopCart>();
            ShopCarts.Add(shopCart);
        }

        public void UpdateShopCart(ShopCart shopCart)
        {
            if (ShopCarts == null)
                return;
            ShopCarts[shopCart.Id - 1] = shopCart;
        }

        public void DeleteShopCart(ShopCart shopCart)
        {
            var shop = ShopCarts.Find(s => s.Id == shopCart.Id);
            ShopCarts.Remove(shop);
        }
        #endregion

        #region Item
        public void CreateItem(Item item)
        {
            if(Items == null)
                return;
            Items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            if (Items == null)
                return;
            Items[item.Id -1] = item;
        }

        public void DeleteItem(Item item)
        {
            if (Items == null)
                return;
            Items.Remove(item);
        }
        #endregion

        #region Store
        public static void CreateStore(Store store)
        {
            if (Stores == null)
                return;
            Stores.Add(store);
        }

        public static void UpdateStore(Store store)
        {
            if (Stores == null)
                return;
            Stores[store.Id - 1] = store;
        }

        public static void DeleteStore(Store store)
        {
            if (Stores == null)
                return;
            Stores.Remove(store);
        }
        #endregion

        #region User
        public static void CreateUsers(User user)
        {
            if (Users == null)
                return;
            Users.Add(user);
        }

        public static void UpdateUser(User user)
        {
            if (Users == null)
                return;
            Users[user.Id - 1] = user;
        }

        public static void DeleteUser(User user)
        {
            if (Users == null)
                return;
            Users.Remove(user);
        }
        #endregion
    }
}