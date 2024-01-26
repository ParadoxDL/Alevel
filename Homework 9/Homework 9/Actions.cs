namespace Homework_9
{
    class Actions
    {
        private readonly Logger logger;

        public Actions(Logger logger)
        {
            this.logger = logger;
        }

        public void Info()
        {
            logger.Log("Info", "Start method");
        }

        public void Warning()
        {
            try
            {
                throw new BusinessException("Skipped logic in method");
            }
            catch (BusinessException e)
            {
                logger.Log("Warning", $"Action got this custom Exception: {e.Message}");
            }
        }

        public void Error()
        {
            try
            {
                throw new Exception("I broke a logic");
            }
            catch (Exception e)
            {
                logger.Log("Error", $"Action failed by reason: {e}");
            }
        }
    }
}
