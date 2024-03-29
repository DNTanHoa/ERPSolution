﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using ZXing.Mobile;
using Android.Widget;
using ERPSolution.MES.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(ERPSolution.MES.Droid.Helpers.QRHelper))]
namespace ERPSolution.MES.Droid.Helpers
{
    public class QRHelper : IQRScanner
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}