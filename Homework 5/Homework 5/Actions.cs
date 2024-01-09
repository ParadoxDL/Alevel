using System;

public class Result
{
    public bool Status { get; set; }
}

public class Actions
{
    private Logger logger;

    public Actions()
    {
        logger = Logger.Instance;
    }

    public Result Info()
    {
        logger.Log("Start method", LogType.Info);
        return new Result { Status = true };
    }

    public Result Warning()
    {
        logger.Log("Skipped logic in method", LogType.Warning);
        return new Result { Status = true };
    }

    public Result Error()
    {
        logger.Log("Action failed by reason: I broke a logic", LogType.Error);
        return new Result { Status = false };
    }
}