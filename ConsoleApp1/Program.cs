﻿using System;
using ConsoleApp1ML.Model.DataModels;
using Microsoft.ML;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeModel();
        }

        private static void ConsumeModel()
        {
            MLContext mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);

            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Use the code below to add input data
            var input = new ModelInput();
            input.OG = 1055;
            input.FG = 1009;
            input.ABV = 6;
            input.IBU = 45;
            input.Color = 15;
            input.BoilGravity = 1050;
            input.BoilSize = 28;
            input.BoilTime = 60;
            input.Size_L_ = 20;
            input.Efficiency = 75;
            input.SugarScale = "Specific Gravity";
            input.BrewMethod = "All Grain";
            input.Name = "Teste Predict";

            // Try model on sample data
            // True is toxic, false is non-toxic
            ModelOutput result = predEngine.Predict(input);

            Console.WriteLine($"Predict: {input.Name} | Prediction ID: {result.Prediction} ");
        }
    }
}
