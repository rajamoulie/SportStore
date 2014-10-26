﻿using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SportsStore.WebUI.Admin.Controllers
{
    public class ProductSpecificationController : Controller
    {
        IProductRepository repository;

        public ProductSpecificationController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int productSpecificationID = 0)
        {
            List<ProductSpecificationDetails> prodSpecDetailsList = new List<ProductSpecificationDetails>();            
            return View("ProductSpecificationList", prodSpecDetailsList);

        }

        [HttpPost]
        public ActionResult Edit(ProductSpecificationDetails ProdSpecDetails)
        {
            var request = Request.Form;
            ProductSpecificationDetails prodSpecDetails = ProdSpecDetails;
            return View(ProdSpecDetails);
        }

        public ActionResult NewSpecificationTable(int TableIndex = 0)
        {
            ProductSpecificationDetails prodSpecDetails = new ProductSpecificationDetails();
            prodSpecDetails.ProductConfigurationDetails = GetConfigurationList();
            ViewBag.TableIndexNo = "SpecificationList_" + TableIndex;
            ViewBag.ButtonAddIndex = "btnAddRow_" + TableIndex;
            ViewBag.TableIndexNoJSID = "#" + ViewBag.TableIndexNo as String;
            ViewBag.ButtonAddIndexJSID = "#" + ViewBag.ButtonAddIndex as string;
            return PartialView("Partial/ProductSpecification", prodSpecDetails);
        }

        private List<ProductSubConfigurationDetails> GetConfigurationList()
        {
            List<ProductSubConfigurationDetails> configurationList = new List<ProductSubConfigurationDetails>();
            configurationList.Add(new ProductSubConfigurationDetails { SubHead = "Name_Key_1", SubSpec = "Name_Value_1" });
            configurationList.Add(new ProductSubConfigurationDetails { SubHead = "Name_Key_2", SubSpec = "Name_Value_2" });
            configurationList.Add(new ProductSubConfigurationDetails { SubHead = "Name_Key_3", SubSpec = "Name_Value_3" });

            return configurationList;
        }
        public string ConvertToXML()
        {
            return null;
        }
    }
}