class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public long ExpectedMinutesInOven() => 40;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public long RemainingMinutesInOven(long ActualMinutesInOven) {
        return ExpectedMinutesInOven() - ActualMinutesInOven;   
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public long PreparationTimeInMinutes(long Layers) {
        return Layers * 2;
    }
        
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public long ElapsedTimeInMinutes(long Layers, long ActualMinutesInOven) {
        return PreparationTimeInMinutes(Layers) + ActualMinutesInOven;
    }
}
