public enum DogStates {
    /// <summary>
    ///     The dog isn't doing anything
    /// </summary>
    Nothing,
    /// <summary>
    ///     The dog is sleeping
    /// </summary>
    Sleeping,
    /// <summary>
    ///     The dog is lying down but not sleeping
    /// </summary>
    LyingDown,
}


public class Dog
{
    /// <summary>
    ///     Sleep for the alloted time
    /// </summary>
    /// <param name="time">
    ///     The time to sleep for
    /// </param>
    public void Sleep(TimeSpan time)
    {
        this.State = DogStates.Sleeping;
        SetWakeTime(DateTime.Now + time);
    }

    /// <summary>
    ///     Take a quick 20 minute nap
    /// </summary>
    /// <param name="time">
    ///     The time to sleep for
    /// </param>
    public void Nap(TimeSpan time)
    {
        this.State = DogStates.Sleeping;
        SetWakeTime(DateTime.Now + TimeSpan.FromMinutes(20));
    }

    /// <summary>
    ///     Consume the specified amount of food in the bowl
    /// </summary>
    /// <param name="foodBowl">
    ///     The bowl to eat from
    /// </param>
    /// <param name="percentage">
    ///     Unused
    /// </param>
    public void Eat(Bowl foodBowl, float percentage)
    {
        float calories = foodBowl.Food.Calories;
        this.Store(calories);
        foodBowl.Empty();
    }

    /// <summary>
    ///     Consume the food lying on the floor
    /// </summary>
    /// <param name="foodBowl">
    ///     The bowl to eat from
    /// </param>
    /// <param name="percentage">
    ///     How much of the food in the bowl to consume
    /// </param>
    public void Eat(Floor floor)
    {
        float calories = floor.Get<Food>().Calories;
        this.Store(calories);
        floor.Clean();
    }

    /// <summary>
    ///     Consume the garbage in the trashcan
    /// </summary>
    /// <param name="TrashCan">
    ///     The trash can to eat from
    /// </param>
    /// <param name="timeUntilCaught">
    ///     How long to eat garbage before getting caught
    /// </param>
    public void Eat(TrashCan trashCan, TimeSpan timeUntilCaught)
    {
        trashCan.KnockOver();
        float consumptionRate = 4;
        float possibleCalories = consumptionRate * timeUntilCaught.TotalMinutes;
        float calories = Math.Max(trashCan.Food.Calories, possibleCalories);
        this.Store(calories);
        this.Run(Location.LivingRoom);
    }

    /// <summary>
    ///     Lie down, not as like a trick or anything, just to not be standing.
    /// </summary>
    public void LieDown()
    {
        this.State = DogStates.LyingDown;
    }

}



public class EnglishBullDog : Dog
{
    /// <summary>
    ///     Constructs a new BullDog instance
    /// </summary>
    public BullDog()
    {
        this.State = DogStates.Nothing;
        LookGrumpy();
    }

    /// <summary>
    ///     Set's the dog's expression to grump, permanently.
    /// </summary>
    public void LookGrumpy()
    {
        SetExpression(Expressions.Grumpy);
        this.Expression.ReadOnly = true;
    }
}








