class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesInOven)
    {
        return ExpectedMinutesInOven() - minutesInOven;
    }


    public int PreparationTimeInMinutes(int numLayers)
    {
        return numLayers * 2; 
    }

    public int ElapsedTimeInMinutes(int numLayers, int minutesInOven)
    {
        return PreparationTimeInMinutes(numLayers) + minutesInOven;
    }
}
