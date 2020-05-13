using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodLineV2.Models
{
    public class ShoppingCartContents
    {
        public string indication_redcell { get; set; }
        public string alert_redcell { get; set; }
        public string indication_platelet { get; set; }
        public string alert_platelet { get; set; }
        public string indication_ffp { get; set; }
        public string alert_ffp { get; set; }
        public string indication_cryoprecipitate { get; set; }
        public string alert_cryoprecipitate { get; set; }
        public string indication_cryosupernatant { get; set; }
        public string alert_cryosupernatant { get; set; }
        public string indication_anti_D { get; set; }
        public string indication_3F_PCC { get; set; }
        public string indication_4F_PCC { get; set; }
        public string indication_F8 { get; set; }
        public string indication_FVIIa { get; set; }

        public List<ShoppingCart> shoppingCart { get; set; }
    }

    public class ShoppingCart
    {
        public string id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string parameter { get; set; }
        public int quantity { get; set; }
    }

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
                    Charge = 250.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPDA at Hct: 0.35 - 0.45",
                    Volume = "350 - 500 ml",
                    Dosage = "~ 6-8 mls/kg for Hb increment of about 10g/L",
                    Process = "None"
                    
                },
                new ProductInfo{
                    Id = "RCSAG",
                    Name = "Red Cells in Additive Solution (SAGM)",
                    Charge = 250.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
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
                    Charge = 280.00,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Leucoreduced red cells suspended in Additive Solution (SAGM) at  Hct: 0.50 - 0.55 and residual leucocyte content of less 1 × 10⁶ per unit.",
                    Volume = "200 - 300 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted to <10^6 leucocyte per bag. May be irradiated on request"
                },
                new ProductInfo{
                    Id = "RCSAG-LD-IRR",
                    Name = "Red Cells in Additive Solution (SAGM), Leucodepleted and Irradiated",
                    Charge = 300.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Leucoreduced and irradiated red cells suspended in Additive Solution (SAGM) at  Hct: 0.50 - 0.55 and residual leucocyte content of less 1 × 10⁶ per unit.",
                    Volume = "200 - 300 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted to <10^6 leucocyte per bag and irradiated at 25Gy to centre"
                },
                new ProductInfo{
                    Id = "RCSAG-PP",
                    Name = "Pedi-pack for Neonatal Transfusion",
                    Charge = 85.00,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 120,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "redcell",
                    Content = "Leucoreduced red cells suspended in Additive Solution (SAGM) at  Hct: 0.50 - 0.55 and residual leucocyte content of less 1 × 10⁶ per unit.",
                    Volume = "30 - 40 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted to <10^6 leucocyte per bag. May be irradiated on request. 3-6 splits from a single red cell unit is allocated on first request."
                },
                new ProductInfo{
                    Id = "RCWB-ET",
                    Name = "Red Cells for Exchange Transfusion, Leucodepleted, Irradiated",
                    Charge = 420.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 30,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted supply. Requires advise from transfusion medicine specialist before request is made. Request must be made by specialist paediatrician only.",
                    Parameter = "redcell",
                    Content = "Red cells suspended in CPD or CPDA at Hct: 0.60 - 0.65.",
                    Volume = "200 - 300 ml",
                    Dosage = "160 ml/kg for a double volume RBC exchange",
                    Process = "Leucodepleted to <10^6 leucocyte per bag and irradiated. Reconstituted with compatible plasma in case of minor ABO incompatibility and Hct readjusted."
                },
                new ProductInfo{
                    Id = "RCWB-LV",
                    Name = "Red Cells for Large Volume Neonatal Transfusion, Leucodepleted, Irradiated",
                    Charge = 420.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 120,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted supply. Requires advise from transfusion medicine medical-officer or specialist before request is made. ",
                    Parameter = "redcell",
                    Content = "Red cells suspended in SAGM or CPDA at Hct: 0.40 - 0.50",
                    Volume = "200 - 300 ml",
                    Dosage = "~ 4 mls/kg for Hb increment of about 10g/L",
                    Process = "Leucodepleted to <10^6 leucocyte per bag and irradiated. May be plasma reconstituted if LVT > 80ml/kg not available."
                },
                new ProductInfo{
                    Id = "PLTRD",
                    Name = "Random Donor Platelets, Unpooled",
                    Charge = 60.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (45 - 65 x 10^9) suspended in plasma containg CPD",
                    Volume = "40 - 60 ml",
                    Dosage = "4-6 units for adult dose, 10 ml/kg for infants. 1 unit should raise platelet count by 5-10 x 10⁹/L in an adult.",
                    Process = "May be irradiated on request"
                },
                new ProductInfo{
                    Id = "PLLR",
                    Name = "Single Donor Apheresis Platelets, Leucodepleted, Irradiated",
                    Charge = 530.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 366,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg ACD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLTPL-LD",
                    Name = "Random Donor Platelets, Pooled, Leucodepleted, Irradiated",
                    Charge = 450.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 366,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg CPD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLTPL-HLA",
                    Name = "Random Donor Platelets, HLA-compatible, Pooled, Leucodepleted, Irradiated",
                    Charge = 850.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 366,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only on special request with HLA immune mediate platelet refractoriness confirmed by HLA antibody screen",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg ACD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLLR-HLA",
                    Name = "Single Donor Apheresis Platelets, HLA-compatible, Leucodepleted, Irradiated",
                    Charge = 850.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only on special request with HLA immune mediate platelet refractoriness confirmed by HLA antibody screen.",
                    Parameter = "platelet",
                    Content = "Platelets (200 - 300 x 10^9) suspended in plasma containg CPD or in platelet additive solution",
                    Volume = "200 - 300 ml",
                    Dosage = "1 unit for adult dose, 10 ml/kg for infants",
                    Process = "Leucodepleted to <10^6 wbc per unit and irradiated"
                },
                new ProductInfo{
                    Id = "PLLR-PP",
                    Name = "Pedi-pack, Single Donor Apheresis Platelets, Leucodepleted, Irradiated",
                    Charge = 250.00,
                    Leucodeplete = 1,
                    Irradiate = 1,
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
                    Id = "PPFFP",
                    Name = "Fresh Frozen Plasma, Random Donor",
                    Charge = 70.00,
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
                    Charge = 70.00,
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
                    Charge = 60.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "none",
                    Comments = "",
                    Parameter = "cryosupernatant",
                    Content = "Cryosupernatant plasma, containing FII, VII, IX and X as primary constituents suspended in CPD",
                    Volume = "150 - 250 ml",
                    Dosage = "1 unit per 10 kg body weight",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPRHD",
                    Name = "Anti-D Immunoglobulin (Rhesonativ)",
                    Charge = 330.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "anti-D",
                    Content = "1,250U Human anti-D immunoglobulin",
                    Volume = "2 ml",
                    Dosage = "Depending on indication",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "PPCC3",
                    Name = "Prothrombin Complex Concentrate, 3-Factor (Prothrombinex)",
                    Charge = 400.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "none",
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
                    Charge = 631.00,
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
                    Charge = 290.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "none",
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
                    Charge = 5690.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Restricted use. Supplied only after consultation with transfusion medicine specialist or haematologist",
                    Parameter = "FVIIa",
                    Content = "2 mg of recombinant FVIIa",
                    Volume = "20 ml",
                    Dosage = "Variable dosing depending on indication",
                    Process = "None"
                },
                new ProductInfo{
                    Id = "T-ABD",
                    Name = "ABO and RhD typing",
                    Charge = 27.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "Test consists of ABO and RhD typing only. Reflexes to additional tests if ABO or RhD discrepancies is identified and Rh phenotyping if patient is found to be RhD-",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-ANC",
                    Name = "Antenatal Screen",
                    Charge = 40.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-GSH",
                    Name = "Group Screen Hold",
                    Charge = 40.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-DAT",
                    Name = "Direct Antiglobulin Test",
                    Charge = 25.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-TIT-AB",
                    Name = "Anti-A/B Titration",
                    Charge = 82.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-TIT-D",
                    Name = "Anti-D Titration",
                    Charge = 72.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-TIT-O",
                    Name = "Antibody Titration (Others)",
                    Charge = 72.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-CAGG",
                    Name = "Cold Agglutinins",
                    Charge = 70.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
                    Content = "",
                    Volume = "",
                    Dosage = "",
                    Process = ""
                },
                new ProductInfo{
                    Id = "T-PHENO",
                    Name = "Red Cell Phenotyping",
                    Charge = 220.00,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = "",
                    Parameter = "test",
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
                    Caption = "Red cells in reserve for a planned procedure.",
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
                    Caption = "Active bleeding with platelet count less than 50 x 10^9/L",
                    Parameter = "platelet",
                    Level = 50
                },
                new Indication
                {
                    Id= 2004,
                    Caption = "Active bleeding or involving an enclosed space (e.g. intracranial, opthalmic) with platelet count less than 100 x 10^9/L",
                    Parameter = "platelet",
                    Level = 100
                },
                new Indication
                {
                    Id= 2005,
                    Caption = "Active bleeding in a patient who has taken a recent dose of anti-platelet medications, or with documented platelet dysfunction.",
                    Parameter = "platelet",
                    Level = 150
                },
                 new Indication
                {
                    Id= 2006,
                    Caption = "Pre-procedure with platelet count less than 50 x 10^9/L",
                    Parameter = "platelet",
                    Level = 50
                },
                new Indication
                {
                    Id= 2007,
                    Caption = "Pre-procedure involving an enclosed space (e.g. intracranial, opthalmic) with platelet count less than 100 x 10^9/L",
                    Parameter = "platelet",
                    Level = 100
                },
                new Indication
                {
                    Id= 2008,
                    Caption = "Pre-procedure in a patient who has taken a recent dose of anti-platelet medications, or with documented platelet dysfunction.",
                    Parameter = "platelet",
                    Level = 150
                },
                new Indication
                {
                    Id= 2009,
                    Caption = "Massive bleeding requiring multiple blood transfusions",
                    Parameter = "platelet",
                    Level = 150
                },
                new Indication
                {
                    Id= 3001,
                    Caption = "INR >1.6 and the patient is bleeding and NOT a candidate for vitamin K",
                    Parameter = "ffp",
                    Level = 1.6
                },
                new Indication
                {
                    Id= 3002,
                    Caption = "INR >1.6 and the patient is planned for a procedure and NOT a candidate for vitamin K",
                    Parameter = "ffp",
                    Level = 1.6
                },
                new Indication
                {
                    Id= 3003,
                    Caption = "Massive bleeding requiring multiple RBC transfusion",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3004,
                    Caption = "Plasma required for therapeutic plasma exchange",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3005,
                    Caption = "Congenital deficiency of coagulation factor not routinely replaceable with factor concentrates (e.g. FXI)",
                    Parameter = "ffp",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 4001,
                    Caption = "Fibrinogen < 1.5g/L with active bleeding",
                    Parameter = "cryoprecipitate",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 4002,
                    Caption = "Fibrinogen < 1.5g/L and patient planned for a procedure",
                    Parameter = "cryoprecipitate",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 4003,
                    Caption = "Congenital deficiency of von Willebrand Factor, Fibrinogen or FXIII",
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
                    Id= 6001,
                    Caption = "Routine antenatal anti-D prophylaxis (RAADP) in RhD- mother at antenatal visit (post 28-weeks)",
                    Parameter = "anti-D",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 6002,
                    Caption = "RAADP in RhD- mother following a pregnancy event e.g. abortion (pre-28 weeks)",
                    Parameter = "anti-D",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 6003,
                    Caption = "RAADP in RhD- mother following a pregnancy event e.g. APH, abortion (post-28 weeks)",
                    Parameter = "anti-D",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 6004,
                    Caption = "RAADP in RhD- mother following delivery of a RhD+ neonate",
                    Parameter = "anti-D",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 6005,
                    Caption = "Anti-D prophylaxis for RhD+ platelet transfusion to RhD- patient",
                    Parameter = "anti-D",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 6006,
                    Caption = "Anti-D prophylaxis for inadvertant transfusion of RhD+ red cells to a RhD- patient",
                    Parameter = "anti-D",
                    Level = 1.5
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
