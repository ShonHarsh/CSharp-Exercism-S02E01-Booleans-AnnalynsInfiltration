using System;

static class QuestLogic
{
    /// <summary>
    /// Takes a boolean value that indicates if the knight is awake. This
    /// method returns true if a fast attack can be made based on the state
    /// of the knight. Otherwise, returns false.
    /// Fast attack: a fast attack can be made if the knight is sleeping,
    /// as it takes time for him to get his armor on, so he will be vulnerable
    /// </summary>
    /// <param name="knightIsAwake">A boolean value representing if the knight
    /// is awake.</param>
    /// <returns>A boolean value representing if a fast attack can be made
    /// because the knight is asleep.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static bool CanFastAttack(bool knightIsAwake)
    {
        bool canFastAttack = false;

        if (knightIsAwake == false)
        {
            canFastAttack = true;
        }
        return canFastAttack;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    /// <summary>
    /// Takes three boolean values, indicating if the knight, archer and the
    /// prisoner, respectively, are awake. The method returns true if the group
    /// can be spied upon, based on the state of the three characters.
    /// Otherwise, returns false.
    /// Spy: the group can be spied upon if at least one of them is awake.
    /// Otherwise, spying is a waste of time.
    /// </summary>
    /// <param name="knightIsAwake">A boolean value representing if the knight
    /// is awake.</param>
    /// <param name="archerIsAwake">A boolean value representing if the archer
    /// is awake.</param>
    /// <param name="prisonerIsAwake">A boolean value representing if the
    /// prisoner is awake.</param>
    /// <returns>A boolean value representing if the group can be spied upon.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        bool canSpy = false;

        if ((archerIsAwake == true) || (knightIsAwake == true) || (prisonerIsAwake == true))
        {
            canSpy = true;
        }
        return canSpy;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    /// <summary>
    /// Takes two boolean values, indicating if the archer and the prisoner,
    /// respectively, are awake. The method returns true if the prisoner can be
    /// signalled, based on the state of the two characters.
    /// Otherwise, returns false.
    /// Signal prisoner: the prisoner can be signalled using bird sounds if the
    /// prisoner is awake and the archer is sleeping, as archers are trained in
    /// bird signaling so they could intercept the message.
    /// </summary>
    /// <param name="archerIsAwake">A boolean value representing if the archer
    /// is awake.</param>
    /// <param name="prisonerIsAwake">A boolean value representing if the
    /// prisoner is awake.</param>
    /// <returns>A boolean value representing if the prrisoner can be signalled.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        bool isSignalPrisoner = false;

        if ((archerIsAwake == false) && (prisonerIsAwake == true))
        {
            isSignalPrisoner = true;
        }

        return isSignalPrisoner;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    /// <summary>
    /// Takes four boolean values. The first three parameters indicate if the
    /// knight, archer and the prisoner, respectively, are awake. The last
    /// parameter indicates if Annalyn's pet dog is present. The method returns
    /// true if the prisoner can be freed based on the state of the three
    /// characters and Annalyn's pet dog presence. Otherwise, it returns false.
    /// </summary>
    /// <param name="knightIsAwake">A boolean value representing if the knight
    /// is awake.</param>
    /// <param name="archerIsAwake">A boolean value representing if the archer
    /// is awake.</param>
    /// <param name="prisonerIsAwake">A boolean value representing if the
    /// prisoner is awake.</param>
    /// <param name="petDogIsPresent">A boolean value representing if the
    /// dog is present.</param>
    /// <returns>A boolean value representing if the prrisonerr can be freed.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool canFreePrisoner = false;

        //If Annalyn has her pet dog with her she can rescue the prisoner if
        //the archer is asleep. The knight is scared of the dog and the
        //archer will not have time to get ready before Annalyn and the
        //prisoner can escape.
        if (petDogIsPresent == true && archerIsAwake == false)
        {
            canFreePrisoner = true;
        }

        //If Annalyn does not have her dog then she and the prisoner must be
        //very sneaky! Annalyn can free the prisoner if the prisoner is awake
        //and the knight and archer are both sleeping, but if the prisoner is
        //sleeping they can't be rescued: the prisoner would be startled by
        //Annalyn's sudden appearance and wake up the knight and archer.
        if ((petDogIsPresent == false) && (prisonerIsAwake == true) && (archerIsAwake == false) && (knightIsAwake == false))
        {
            canFreePrisoner = true;
        }

        return canFreePrisoner;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
