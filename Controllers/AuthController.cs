using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backend.DBContext;
using System.Web.Http.Cors;

namespace Backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[RoutePrefix("Api/login")]
    public class AuthController : ApiController
    {
        // https://localhost:xxx/api/auth/staff
        [HttpGet]
        [ActionName("Staff")]
        public IHttpActionResult GetStaff()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                
                var users = _databaseContext.STAFF_.ToList();
                return Ok(new { result = users, message = "success" });
            }    
        }

        [HttpGet]
        [ActionName("Staff")]
        public IHttpActionResult GetStaffByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.STAFF_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }  
        }

        [HttpPut]
        [ActionName("AddStaff")]
        public IHttpActionResult AddStaff(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.STAFF_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.STAFF_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelStaff")]
        public IHttpActionResult DelStaff(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.STAFF_.SingleOrDefault(o => o.id == id);
                if(user != null)
                {
                    var users = _databaseContext.STAFF_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Bay")]
        public IHttpActionResult GetBay()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_BAY_STATION__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Bay")]
        public IHttpActionResult GetBayByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_BAY_STATION__.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddBay")]
        public IHttpActionResult AddBay(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_BAY_STATION__.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C_BAY_STATION__.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelBay")]
        public IHttpActionResult DelBay(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_BAY_STATION__.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C_BAY_STATION__.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Customer")]
        public IHttpActionResult GetCustomer()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.CUSTOMER_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Customer")]
        public IHttpActionResult GetCustomerByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.CUSTOMER_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddCustomer")]
        public IHttpActionResult AddCustomer(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.CUSTOMER_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.CUSTOMER_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelCustomer")]
        public IHttpActionResult DelCustomer(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.CUSTOMER_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.CUSTOMER_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Gas")]
        public IHttpActionResult GetGas()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.GASNEW_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Gas")]
        public IHttpActionResult GetGasByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.GASNEW_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddGas")]
        public IHttpActionResult AddGas(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.GASNEW_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.GASNEW_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelGas")]
        public IHttpActionResult DelGas(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.GASNEW_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.GASNEW_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Invoice")]
        public IHttpActionResult GetInvoice()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C7invoice_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Invoice")]
        public IHttpActionResult GetInvoiceByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C7invoice_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddInvoice")]
        public IHttpActionResult AddInvoice(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C7invoice_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C7invoice_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelInvoice")]
        public IHttpActionResult DelInvoice(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C7invoice_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C7invoice_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Journal")]
        public IHttpActionResult GetJournal()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_JOUNAL_TRANSECTION__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Journal")]
        public IHttpActionResult GetJournalByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_JOUNAL_TRANSECTION__.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddJournal")]
        public IHttpActionResult AddJournal(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_JOUNAL_TRANSECTION__.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C_JOUNAL_TRANSECTION__.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelJournal")]
        public IHttpActionResult DelJournal(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_JOUNAL_TRANSECTION__.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C_JOUNAL_TRANSECTION__.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Payment")]
        public IHttpActionResult GetPayment()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.PAYMENT_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Payment")]
        public IHttpActionResult GetPaymentByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.PAYMENT_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddPayment")]
        public IHttpActionResult AddPayment(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.PAYMENT_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.PAYMENT_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelPayment")]
        public IHttpActionResult DelPayment(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.PAYMENT_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.PAYMENT_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Purchase")]
        public IHttpActionResult GetPurchase()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C6PO_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Purchase")]
        public IHttpActionResult GetPurchaseByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C6PO_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddPurchase")]
        public IHttpActionResult AddPurchase(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C6PO_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C6PO_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelPurcahse")]
        public IHttpActionResult DelPurchase(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C6PO_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C6PO_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("SaleOffice")]
        public IHttpActionResult GetSaleOffice()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_SALE_OFFICE__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("SaleOffice")]
        public IHttpActionResult GetSaleOfficeByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_SALE_OFFICE__.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddSaleOffice")]
        public IHttpActionResult AddSaleOffice(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_SALE_OFFICE__.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C_SALE_OFFICE__.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelSaleOffice")]
        public IHttpActionResult DelSaleOffice(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_SALE_OFFICE__.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C_SALE_OFFICE__.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Truck")]
        public IHttpActionResult GetTruck()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.TRUCK_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Truck")]
        public IHttpActionResult GetTruckByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.TRUCK_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddTruck")]
        public IHttpActionResult AddTruck(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.TRUCK_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.TRUCK_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelTruck")]
        public IHttpActionResult DelTruck(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.TRUCK_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.TRUCK_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Weight")]
        public IHttpActionResult GetWeight()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.WEIGHT_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Weight")]
        public IHttpActionResult GetWeightByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.WEIGHT_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddWeight")]
        public IHttpActionResult AddWeight(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.WEIGHT_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.WEIGHT_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelWeigt")]
        public IHttpActionResult DelWeihht(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.WEIGHT_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.WEIGHT_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Recon")]
        public IHttpActionResult GetRecon()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C3Recon_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Recon")]
        public IHttpActionResult GetReconByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C3Recon_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddRecon")]
        public IHttpActionResult AddRecon(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C3Recon_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C3Recon_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelRecon")]
        public IHttpActionResult DelRecon(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C3Recon_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C3Recon_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Income")]
        public IHttpActionResult GetIncome()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C4Income_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Income")]
        public IHttpActionResult GetIncomeByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C4Income_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddIncome")]
        public IHttpActionResult AddIncome(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C4Income_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C4Income_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelIncome")]
        public IHttpActionResult DelIncome(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C4Income_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C4Income_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Inventory")]
        public IHttpActionResult GetInventory()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C5Inventory_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Inventory")]
        public IHttpActionResult GetInventoryByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C5Inventory_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddInventory")]
        public IHttpActionResult AddInventory(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C5Inventory_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C5Inventory_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelInventory")]
        public IHttpActionResult DelInventory(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C5Inventory_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C5Inventory_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("PO")]
        public IHttpActionResult GetPO()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C6PO_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("PO")]
        public IHttpActionResult GetPOByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C6PO_.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddPO")]
        public IHttpActionResult AddPO(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C6PO_.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C6PO_.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelPO")]
        public IHttpActionResult DelPO(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C6PO_.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C6PO_.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Invoice2")]
        public IHttpActionResult GetInvoice2()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_7invoice__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("Invoice2")]
        public IHttpActionResult GetInvoice2Byid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C_7invoice__.SingleOrDefault(o => o.id == id);
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpPut]
        [ActionName("AddInvoice2")]
        public IHttpActionResult AddInvoice2(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_7invoice__.SingleOrDefault(o => o.id == id);
                if (user == null)
                {
                    var users = _databaseContext.C_7invoice__.Add(user);
                    _databaseContext.SaveChanges();
                    return Ok(new { result = users, message = "success" });
                }
                return Ok(new { message = "failed" });
            }
        }

        [HttpDelete]
        [ActionName("DelInvoice2")]
        public IHttpActionResult DelInvoice2(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var user = _databaseContext.C_7invoice__.SingleOrDefault(o => o.id == id);
                if (user != null)
                {
                    var users = _databaseContext.C_7invoice__.Remove(user);
                    _databaseContext.SaveChanges();
                }
                return Ok(new { message = "success" });
            }
        }

        [HttpGet]
        [ActionName("General")]
        public IHttpActionResult GetGeneral()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.Gen_Journal_.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("General")]
        public IHttpActionResult GetGeneralByid(int id)
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var sid = id.ToString();
                var year = sid.Substring(0, 4);
                var month = sid.Substring(4, 2);
                var day = sid.Substring(6, 2);
                var nid = year+"-"+month+"-"+day+"T00:00:00";
                var users = _databaseContext.Gen_Journal_.AsEnumerable().Where(s => s.Date == Convert.ToDateTime(nid)).Select(a=> new { a.Date,a.Account,a.Ref,a.Debit,a.Credit}).ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("LedgerAR")]
        public IHttpActionResult GetLedgerAR()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C2Ledeger_AR__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("LedgerAP")]
        public IHttpActionResult GetLedgerAP()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C2Ledger_AP__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("LedgerCash")]
        public IHttpActionResult GetLedgerCash()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C2Ledger_Cash__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("LedgerStacokDiesel")]
        public IHttpActionResult GetLedgerStacokDiesel()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C2Ledger_StockDeisel__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }

        [HttpGet]
        [ActionName("LedgerStacokGasohol95")]
        public IHttpActionResult GetLedgerStacokGasohol95()
        {
            using (Capston2Entities8 _databaseContext = new Capston2Entities8())
            {
                var users = _databaseContext.C2Ledger_StockGasohol95__.ToList();
                return Ok(new { result = users, message = "success" });
            }
        }


    }
}