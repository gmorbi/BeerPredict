//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace ConsoleApp1ML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("BeerID"), LoadColumn(0)]
        public float BeerID { get; set; }


        [ColumnName("Name"), LoadColumn(1)]
        public string Name { get; set; }


        [ColumnName("URL"), LoadColumn(2)]
        public string URL { get; set; }


        [ColumnName("Style"), LoadColumn(3)]
        public string Style { get; set; }


        [ColumnName("StyleID"), LoadColumn(4)]
        public float StyleID { get; set; }


        [ColumnName("Size_L_"), LoadColumn(5)]
        public float Size_L_ { get; set; }


        [ColumnName("OG"), LoadColumn(6)]
        public float OG { get; set; }


        [ColumnName("FG"), LoadColumn(7)]
        public float FG { get; set; }


        [ColumnName("ABV"), LoadColumn(8)]
        public float ABV { get; set; }


        [ColumnName("IBU"), LoadColumn(9)]
        public float IBU { get; set; }


        [ColumnName("Color"), LoadColumn(10)]
        public float Color { get; set; }


        [ColumnName("BoilSize"), LoadColumn(11)]
        public float BoilSize { get; set; }


        [ColumnName("BoilTime"), LoadColumn(12)]
        public float BoilTime { get; set; }


        [ColumnName("BoilGravity"), LoadColumn(13)]
        public float BoilGravity { get; set; }


        [ColumnName("Efficiency"), LoadColumn(14)]
        public float Efficiency { get; set; }


        [ColumnName("MashThickness"), LoadColumn(15)]
        public float MashThickness { get; set; }


        [ColumnName("SugarScale"), LoadColumn(16)]
        public string SugarScale { get; set; }


        [ColumnName("BrewMethod"), LoadColumn(17)]
        public string BrewMethod { get; set; }


        [ColumnName("PitchRate"), LoadColumn(18)]
        public float PitchRate { get; set; }


        [ColumnName("PrimaryTemp"), LoadColumn(19)]
        public float PrimaryTemp { get; set; }


        [ColumnName("PrimingMethod"), LoadColumn(20)]
        public string PrimingMethod { get; set; }


        [ColumnName("PrimingAmount"), LoadColumn(21)]
        public string PrimingAmount { get; set; }


    }
}
