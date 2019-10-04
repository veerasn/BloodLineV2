using System;
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
        public int Quantity { get; set; }
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
                },
                new ProductInfo{
                    Id = "HLA-PLRD",
                    Name = "HLA-compatible Platelet from Random Donors, Unpooled",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
                },
                new ProductInfo{
                    Id = "PLTPL-LD",
                    Name = "Random Donor Platelet, Pooled, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a"
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
                    Comments = ""
                },
                new ProductInfo{
                    Id = "HLA-PLLR",
                    Name = "HLA-compatible Single Donor Apheresis Platelet, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 99999,
                    Lowerage = 120,
                    Filelocation = "a",
                    Comments = ""
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
                    Comments = ""
                },
                new ProductInfo{
                    Id = "HLA-PLLR-PP",
                    Name = "HLA-compatible Pedi-pack, Single Donor Apheresis Platelet, Leucodepleted",
                    Charge = 230,
                    Leucodeplete = 1,
                    Irradiate = 1,
                    Upperage = 365,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
                },
                new ProductInfo{
                    Id = "RHD",
                    Name = "Anti-D Immunoglobulin (WinRho)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
                },
                new ProductInfo{
                    Id = "PDCC3",
                    Name = "Prothrombin Complex Concentrate, 3-Factor (Prothrombinex)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
                },
                new ProductInfo{
                    Id = "PDCC4",
                    Name = "Prothrombin Complex Concentrate, 4-Factor (Octaplex)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
                },
                new ProductInfo{
                    Id = "PDF8",
                    Name = "Factor 8 Concentrate, Plasma-derived, Intermediate Purity",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
                },
                new ProductInfo{
                    Id = "PDF7a",
                    Name = "Recombinant Factor VIIa (NovoSeven)",
                    Charge = 230,
                    Leucodeplete = 0,
                    Irradiate = 0,
                    Upperage = 99999,
                    Lowerage = 0,
                    Filelocation = "a",
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Comments = ""
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
                    Caption = "Prophylactic transfusion to prevent spontaneous bleeding in a stable patient with platelet count <10 x 10^9/L",
                    Parameter = "Plt",
                    Level = 10
                },
                new Indication
                {
                    Id= 2002,
                    Caption = "Prophylactic transfusion to prevent spontaneous bleeding in patient with consumptive state (e.g. high fever, sepsis, DIC, splenomegaly) and platelet count <20 x 10^9/L",
                    Parameter = "Plt",
                    Level = 20
                },
                new Indication
                {
                    Id= 2003,
                    Caption = "Active bleeding or pre-procedure with platelet count <50 x 10^9/L",
                    Parameter = "Plt",
                    Level = 50
                },
                new Indication
                {
                    Id= 2004,
                    Caption = "Active bleeding or pre-procedure involving an enclosed space (e.g. intracranial, opthalmic) with platelet count <100 x 10^9/L",
                    Parameter = "Plt",
                    Level = 100
                },
                new Indication
                {
                    Id= 2005,
                    Caption = "Pre-procedure or bleeding patient who has taken a recent dose of anti-platelet medications, or with documented platelet dysfunction.",
                    Parameter = "Plt",
                    Level = 150
                },
                new Indication
                {
                    Id= 2006,
                    Caption = "Massive bleeding requiring multiple blood transfusions",
                    Parameter = "Plt",
                    Level = 150
                },
                new Indication
                {
                    Id= 2009,
                    Caption = "Other",
                    Parameter = "Plt",
                    Level = 150
                },
                new Indication
                {
                    Id= 3001,
                    Caption = "INR >1.6 and the patient is currently bleeding or pre-procedure and NOT a candidate for vitamin K",
                    Parameter = "INR",
                    Level = 1.6
                },
                new Indication
                {
                    Id= 3002,
                    Caption = "Massive bleeding requiring multiple RBC transfusion",
                    Parameter = "INR",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3003,
                    Caption = "Plasma required for therapeutic plasma exchange",
                    Parameter = "INR",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3004,
                    Caption = "Congenital deficiency of coagulation factor not routinely replaceable with factor concentrates (e.g. FXI)",
                    Parameter = "INR",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 3009,
                    Caption = "Other",
                    Parameter = "INR",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 4001,
                    Caption = "Fibrinogen < 1.5g/L and active bleeding or pre-procedure",
                    Parameter = "FBG",
                    Level = 1.5
                },
                new Indication
                {
                    Id= 4002,
                    Caption = "Congenital deficiency of von Willebrand Factor, Fibrinogen or FXIII",
                    Parameter = "FBG",
                    Level = 6
                },
                new Indication
                {
                    Id= 4009,
                    Caption = "Other",
                    Parameter = "FBG",
                    Level = 6
                },
                new Indication
                {
                    Id= 5001,
                    Caption = "Thrombotic thrombocytopenic purpura. Cryo-poor plasma required for therapeutic plasma exchange",
                    Parameter = "INR",
                    Level = 0.9
                },
                new Indication
                {
                    Id= 5009,
                    Caption = "Other",
                    Parameter = "INR",
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
