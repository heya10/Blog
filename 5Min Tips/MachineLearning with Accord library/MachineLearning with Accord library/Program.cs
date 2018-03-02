using System;
using Accord.DataSets;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;

namespace MachineLearning_with_Accord_library
{
	class Program
	{
		public static void Main(string[] args)
		{
			//getting example data
			Iris iris = new Iris();
			
			//we are creating training data arrays
			double[][] input = new double[147][];
			int[] output = new int[147];
			
			//we process 'Iris' data and delete 1 from each type for later test purpose
			int j = 0;
			for(int i=0; i<147; i++){
				if(i!=0||i!=50||i!=100){
					input[j] = new double[4];
					output[j] = iris.ClassLabels[i];
					for(int k=0;k<4;k++)
						input[j][k] = iris.Instances[i][k];
					j++;
				}
			}
			
			//learning algorithm for decision tree
			C45Learning teacher = new C45Learning(new[]{
          		DecisionVariable.Continuous(iris.VariableNames[0]),
          		DecisionVariable.Continuous(iris.VariableNames[1]),
          		DecisionVariable.Continuous(iris.VariableNames[2]),
          		DecisionVariable.Continuous(iris.VariableNames[3]),
          	});
			
			//model learning
			DecisionTree tree = teacher.Learn(input, output);
			
			//If we would have some other irises we could just wrote like this
			//DecisionTree tree = teacher.Learn(iris.Instances, iris.ClassLabels);
			//but we prefer to left some for test purpose (to check if our programm is working fine)
			
			//testing our model
			double[][] test = {iris.Instances[0],iris.Instances[50],iris.Instances[100]};
			int[] answers = tree.Decide(test);
			
			Console.WriteLine("Answer should be as follow:\n0,1,2,\nAnswer is:");
			
			foreach(int ans in answers)
				Console.Write(ans + ",");
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}