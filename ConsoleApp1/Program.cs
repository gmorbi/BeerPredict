using System;
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
            input.OG = 1090;
            input.FG = 1013;
            input.ABV = 10;
            input.IBU = 150;
            input.Color = 100;
            input.BoilGravity = 1050;
            input.BoilSize = 28;
            input.BoilTime = 60;
            input.Size_L_ = 20;
            input.Efficiency = 75;
            input.SugarScale = "Specific Gravity";
            input.BrewMethod = "All Grain";
            input.Name = "No named beer";

            // Try model on sample data
            // True is toxic, false is non-toxic
            ModelOutput result = predEngine.Predict(input);

            Console.WriteLine($"Predict: {input.Name} | Prediction ID: {result.Prediction} ");
            Console.ReadKey();
        }
    }
}
