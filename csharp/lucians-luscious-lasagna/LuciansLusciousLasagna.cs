class Lasagna
{
    // returns initial test's value expected 40
    public int ExpectedMinutesInOven(){
        return 40;
    }
    // takes expectedminutes' return and reduces it by input
    // returns how many minutes the lasagna has left in the oven
    public int RemainingMinutesInOven(int r){
        int x = ExpectedMinutesInOven() - r;
        return x;
    }
    // takes layers input and multiplies it by 2 to represent layers * 2 minutes
    // returns how many minutes spent preparing lasagna
    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }
    // first param is number of layers added to lasagna, second param is the number of minutes lasagna has been in the oven
    // returns how many minutes worked on total, sum of prep time and time spent in oven
    public int ElapsedTimeInMinutes(int layers, int minutesinoven){
        return (layers * 2) + minutesinoven;
    }
}
