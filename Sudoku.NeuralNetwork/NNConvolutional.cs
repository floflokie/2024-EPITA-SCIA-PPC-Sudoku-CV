using Sudoku.Shared;
using Python.Runtime;

namespace Sudoku.NeuralNetwork;

public class NNConvolutional : PythonSolverBase
{
    public override SudokuGrid Solve(SudokuGrid s)
    {
        using (PyModule scope = Py.CreateScope())
        {

            // Injectez le script de conversion
            AddNumpyConverterScript(scope);

            // Convertissez le tableau .NET en tableau NumPy
            var pyCells = AsNumpyArray(s.Cells, scope);

            // create a Python variable "instance"
            //scope.Import("torch");
            //scope.Import("torch.nn", asname: "nn");
            //scope.Import
            //scope.Exec("%pip install -r requirements.txt");
            scope.Set("instance", pyCells);

            // run the Python script
            string code = Resources1.solve_convolutional_py;
            //Console.WriteLine(code);
            //Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            scope.Exec(code);

            PyObject result = scope.Get("result");

            // Convertissez le résultat NumPy en tableau .NET
            var managedResult = AsManagedArray(scope, result);

            // Console.WriteLine(result);

            return new SudokuGrid() { Cells = managedResult };
        }
        
        return s;
    }

    protected override void InitializePythonComponents()
    {
        InstallPipModule("numpy");
        InstallPipModule("keras");
        InstallPipModule("tensorflow");
        
        base.InitializePythonComponents();
    }

}