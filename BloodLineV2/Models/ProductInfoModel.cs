﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodLineV2.Models
{
    public class ProductInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Charge { get; set; }
        public int Leucodeplete { get; set; }
        public int Irradiate { get; set; }
        public int Upperage { get; set; }
        public int Lowerage { get; set; }
        public string Filelocation { get; set; }
        public string Comments { get; set; }
        public string Parameter { get; set; }
        public int Quantity { get; set; }
        public string Content { get; set; }
        public string Volume { get; set; }
        public string Dosage { get; set; }
        public string Process { get; set; }
    }

    public class Indication
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Parameter { get; set; }
        public double Level { get; set; }
    }

    public class ProductInfoModel
    {
        private List<ProductInfo> bloodproducts;
        private List<Indication> indications;

        public ProductInfoModel()
        {
            this.bloodproducts = new List<ProductInfo>()
            {
                new ProductInfo{
                    Id = "RCWB",
                    Name = "Whole Blood",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPDA at Hct: 0.35 - 0.40",
                    Volume = "350 - 500 ml",
                    Dosage = "~ 6-8 mls/kg for Hb increment of about 10g/L",
                    Process = "None"
                    
                },
                new ProductInfo{
                    Id = "RCSAG",
                    Name = "Red Cells in Additive Solution (SAGM)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "RCSAG.pdf",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPD or SAGM at Hct: 0.50 - 0.65",
                    Volume = "200 - 300 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "RCSAG-LD",
                    Name = "Red Cells in Additive Solution (SAGM), Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPD or SAGM at Hct: 0.50 - 0.65",
                    Volume = "200 - 300 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted to <10^6 leucocyte per bag"
                },
                new ProductInfo{
                    Id = "RCSAG-PP",
                    Name = "Pedi-pack for Neonatal Transfusion",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 120,
                    Lowerage = 0,
                    Filelocation = "none",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPD or SAGM at Hct: 0.50 - 0.65",
                    Volume = "30 - 40 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted to <10^6 leucocyte per bag"
                },
                new ProductInfo{
                    Id = "RCWB-ET",
                    Name = "Red Cells for Exchange Transfusion, Leucodepleted, Irradiated",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 30,
                    Lowerage = 0,
                    Filelocation = "none",
                    Comments = "Restricted supply. Requires advise from transfusion medicine medical-officer or specialist before request is made.",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPD or CPDA at Hct: 0.60 - 0.65",
                    Volume = "200 - 300 ml",
                    Dosage = "160 ml/kg for a double volume RBC exchange",
                    Process = "Leucodepleted to <10^6 leucocyte per bag and irradiated"
                },
                new ProductInfo{
                    Id = "RCWB-LV",
                    Name = "Red Cells for Large Volume Neonatal Transfusion, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 120,
                    Lowerage = 0,
                    Filelocation = "none",
                    Comments = "Restricted supply. Requires advise from transfusion medicine medical-officer or specialist before request is made. ",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPD or CPDA at Hct: 0.40 - 0.50",
                    Volume = "200 - 300 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted or irradiated only in request with indication"
                },
                new ProductInfo{
                    Id = "PLTRD",
                    Name = "Platelet from Random Donors, Unpooled",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (45 - 65 x 10^9) suspended in plasma containg CPD",
                    Volume = "50 - 60 ml",
                    Dosage = "4-6 units for adult dose, 10 ml/kg for infants",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PLRD-HLA",
                    Name = "HLA-compatible Platelet from Random Donors, Pooled",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only on special request with HLA immune mediate platelet refractoriness confirmed by HLA antibody screen",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg ACD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLTPL-LD",
                    Name = "Random Donor Platelet, Pooled, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg CPD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLTLR",
                    Name = "Single Donor Apheresis Platelet, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg ACD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLLR-HLA",
                    Name = "HLA-compatible Single Donor Apheresis Platelet, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only on special request with HLA immune mediate platelet refractoriness confirmed by HLA antibody screen",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg CPD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLTLR-PP",
                    Name = "Pedi-pack, Single Donor Apheresis Platelet, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 365,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (40 - 50 x 10^9) suspended in plasma containg ACD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "10 - 20 ml/kg",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLLR-PP-HLA",
                    Name = "HLA-compatible Pedi-pack, Single Donor Apheresis Platelet, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 365,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only on special request with HLA immune mediate platelet refractoriness confirmed by HLA antibody screen",
                    Parameter = "platelet",
                    Content = "Platelets (40 - 50 x 10^9) suspended in plasma containg CPD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PPFFP",
                    Name = "Fresh Frozen Plasma, Random Donor",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "ffp",
                    Content = "Plasma suspended in CPD",
                    Volume = "200 - 300 ml",
                    Dosage = "10 - 20 ml/kg",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPCPT",
                    Name = "Cryoprecipitate, Random Donor, Unpooled",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "cryoprecipitate",
                    Content = "Cryoprecipitated plasma, containing FVIII, vWF and fibrinogen as primary constituents suspended in CPD",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit per 10 kg body weight",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPCSP",
                    Name = "Cryo-poor Plasma,Random Donor, Unpooled",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "cryosupernatant",
                    Content = "Cryosupernatant plasma, containing FII, VII, IX and X as primary constituents suspended in CPD",
                    Volume = "150 - 250 ml",
                    Dosage = "1 unit per 10 kg body weight",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPRHD",
                    Name = "Anti-D Immunoglobulin (WinRho)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "anti-D",
                    Content = "1,500U Human anti-D immunoglobulin",
                    Volume = "20 ml",
                    Dosage = "Depending on indication",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPCC3",
                    Name = "Prothrombin Complex Concentrate, 3-Factor (Prothrombinex)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only after consultation with transfusion medicine specialist of haematologist",
                    Parameter = "3F-PCC",
                    Content = "500U of FIX aith variable FX and FII",
                    Volume = "20 ml",
                    Dosage = "20 - 50U/kg, depending on indication",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPCC4",
                    Name = "Prothrombin Complex Concentrate, 4-Factor (Octaplex)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only after consultation with transfusion medicine specialist of haematologist",
                    Parameter = "4F-PCC",
                    Content = "500U of FIX with variable FX, FVII and FII",
                    Volume = "20 ml",
                    Dosage = "20 - 50U/kg, depending on indication",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPF8",
                    Name = "Factor 8 Concentrate, Plasma-derived, Intermediate Purity",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only after consultation with transfusion medicine specialist of haematologist",
                    Parameter = "F8",
                    Content = "500U of FVII",
                    Volume = "20 ml",
                    Dosage = "1U/kg will raise FVIII by about 0.02U",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPF7a",
                    Name = "Recombinant Factor VIIa (NovoSeven)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only after consultation with transfusion medicine specialist of haematologist",
                    Parameter = "FVIIa",
                    Content = "2 mg of recombinant FVIIa",
                    Volume = "20 ml",
                    Dosage = "Variable dosing depending on indication",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "T-ABD",
                    Name = "ABO and RhD typing",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Test consists of ABO and RhD typing only. Reflexes to additional tests if ABO or RhD discrepancies is identified and Rh phenotyping if patient is found to be RhD-",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-ANC",
                    Name = "Antenatal Screen",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-GSH",
                    Name = "Group Screen & Hold",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-DAT",
                    Name = "Direct Antiglobulin Test",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-TIT-AB",
                    Name = "Anti-A/B Titration",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-TIT-D",
                    Name = "Anti-D Titration",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-TIT-O",
                    Name = "Antibody Titration (Others)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
            };


            this.indications = new List<Indication>()
            {
                new Indication
                {
                    Id= 1001,
                    Caption = "Hb less than 70 g/L in a hemodynamically stable ICU patient.",
                    Parameter = "redcell",
                    Level = 70
                },
                new Indication
                {
                    Id= 1002,
                    Caption = "Hb less than 80 g/L in a non- ICU patient with symptomatic anaemia.",
                    Parameter = "redcell",
                    Level = 80
                },
                new Indication
                {
                    Id= 1003,
                    Caption = "Hb less than 100 g/L in a patient experiencing acute ischaemiac cardiovascular disease (e.g. angina pectoris, acute myocardial infarction).",
                    Parameter = "redcell",
                    Level = 100
                },
                new Indication
                {
                    Id= 1004,
                    Caption = "Acute bleeding with hemodynamic instability requiring urgent RBC transfusion.",
                    Parameter = "redcell",
                    Level = 140
                },
                new Indication
                {
                    Id= 1005,
                    Caption = "Red cells in reserve for a planned procedure where GSH is not justified.",
                    Parameter = "redcell",
                    Level = 140
                },
                new Indication
                {
                    Id= 1006,
                    Caption = "Red cells for tranfusion dependant patients where a higher haemoglobin threshold may be required e.g. thalassaemia.",
                    Parameter = "redcell",
                    Level = 140
                },
                new Indication
                {
                    Id= 1009,
                    Caption = "Other",
                    Parameter = "redcell",
                    Level = 140
                },
                new Indication
                {
                    Id= 2001,
                    Caption = "Prophylactic transfusion to prevent spontaneous bleeding in a stable patient with platelet count less than 10 x 10^9/L",
                    Parameter = "platelet",
                    Level = 10
                },
                new Indication
                {
                    Id= 2002,
                    Caption = "Prophylactic transfusion to prevent spontaneous bleeding in patient with consumptive state (e.g. high fever, sepsis, DIC, splenomegaly) and platelet count less than 20 x 10^9/L",
                    Parameter = "platelet",
                    Level = 20
                },
                new Indication
                {
                    Id= 2003,
                    Caption = "Active bleeding or pre-procedure with platelet count less than 50 x 10^9/L",
                    Parameter = "platelet",
                    Level = 50
                },
                new Indication
                {
                    Id= 2004,
                    Caption = "Active bleeding or pre-procedure involving an enclosed space (e.g. intracranial, opthalmic) with platelet count less than 100 x 10^9/L",
                    Parameter = "platelet",
                    Level = 100
                },
                new Indication
                {
                    Id= 2005,
                    Caption = "Pre-procedure or bleeding patient who has taken a recent dose of anti-platelet medications, or with documented platelet dysfunction.",
                    Parameter = "platelet",
                    Level = 150
                },
                new Indication
                {
                    Id= 2006,
                    Caption = "Massive bleeding requiring multiple blood transfusions",
                    Parameter = "platelet",
                    Level = 150
                },
                new Indication
                {
                    Id= 2009,
                    Caption = "Other",
                    Parameter = "platelet",
                    Level = 150
                },
                new Indication
                {
                    Id= 3001,
                    Caption = "INR >1.6 and the patient is currently bleeding or pre-procedure and NOT a candidate for vitamin K",
                    Parameter = "ffp",
                    Level = 1.6
                },
                new Indication
                {
                    Id= 3002,
                    Caption = "Massive bleeding requiring multiple RBC transfusion",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3003,
                    Caption = "Plasma required for therapeutic plasma exchange",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3004,
                    Caption = "Congenital deficiency of coagulation factor not routinely replaceable with factor concentrates (e.g. FXI)",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3009,
                    Caption = "Other",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 4001,
                    Caption = "Fibrinogen < 1.5g/L and active bleeding or pre-procedure",
                    Parameter = "cryoprecipitate",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 4002,
                    Caption = "Congenital deficiency of von Willebrand Factor, Fibrinogen or FXIII",
                    Parameter = "cryoprecipitate",
                    Level = 6
                },
                new Indication
                {
                    Id= 4009,
                    Caption = "Other",
                    Parameter = "cryoprecipitate",
                    Level = 6
                },
                new Indication
                {
                    Id= 5001,
                    Caption = "Thrombotic thrombocytopenic purpura. Cryo-poor plasma required for therapeutic plasma exchange",
                    Parameter = "cryosupernatant",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 5009,
                    Caption = "Other",
                    Parameter = "cryosupernatant",
                    Level = 0.9
                }
            };
        }

        public List<ProductInfo> ProductInfoAll()
        {
            return this.bloodproducts;
        }

        public List<Indication> IndicationAll()
        {
            return this.indications;
        }
    }
}
