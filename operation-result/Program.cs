using OperationResult.Library;

Result<Exception, int> result = Result.Run(OperationWithReturn);
Result<Exception, bool> resultException = Result.Run(OperationWithException);


Console.WriteLine($"Result with return: IsSuccess: {result.IsSuccess}  Value: {(result.IsSuccess ? result.Success : result.Failure)}");
Console.WriteLine($"Result with Exception: IsSuccess: {resultException.IsSuccess}  Value: {(resultException.IsSuccess ? resultException.Success : resultException.Failure)}");

Console.ReadKey();

int OperationWithReturn()
{
    return 10;
}

bool OperationWithException()
{
    throw new Exception("Result would be an exception!!!");
}