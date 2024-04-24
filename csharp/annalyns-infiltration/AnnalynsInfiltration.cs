using System;
// seems like a simple challenge of understanding boolean operators
static class QuestLogic
{
    // expression-bodied method
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake == false && archerIsAwake == false  && prisonerIsAwake == false){
            return false;
        }
        else return true;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake == false && prisonerIsAwake == true){
            return true;
        }
        else return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == false && petDogIsPresent == false){
            return false;
        }
        if (knightIsAwake == true && archerIsAwake == true && prisonerIsAwake == true && petDogIsPresent == true){
            return false;
        }
        if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == false && petDogIsPresent == true){
            return true;
        }
        if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == true){
            return true;
        }
        if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == false){
            return true;
        }
        if (knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == true){
            return true;
        }
        if (knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == false && petDogIsPresent == true){
            return true;
        }

        else return false;
    }
}
