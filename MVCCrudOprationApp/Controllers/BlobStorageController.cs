﻿using Microsoft.WindowsAzure.Storage.Blob;
using MVCCrudOprationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudOprationApp.Controllers
{
    public class BlobStorageController : Controller
    {
        // GET: BlobStorage
        private CloudBlobContainer blobContainer;

        // GET: BlobStorage
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase uploadFile)
        {
            foreach (string file in Request.Files)
            {
                uploadFile = Request.Files[file];
            }
            // Container Name - picture  
            BlobManager BlobManagerObj = new BlobManager("picture");
            string FileAbsoluteUri = BlobManagerObj.UploadFile(uploadFile);

            return RedirectToAction("Get");
        }



        public ActionResult Get()
        {
            // Container Name - picture  
            BlobManager BlobManagerObj = new BlobManager("picture");
            List<string> fileList = BlobManagerObj.BlobList();
            return View(fileList);
        }


        public ActionResult Delete(string uri)
        {
            // Container Name - picture  
            BlobManager BlobManagerObj = new BlobManager("picture");
            BlobManagerObj.DeleteBlob(uri);
            return RedirectToAction("Get");
        }


    }
}