
[Attribute(language = "C#")]
public class BrownFox : Pangram
{
    /// <summary>
    ///     The <see cref="BrownFox"/> is always quick.
    /// </summary>
    private const bool isQuick = true;

    #region Methods

    /// <summary>
    ///     Jump over these dogs
    /// </summary>
    /// <param name="dogs">
    ///     The lazy <see cref="Dog">dogs</see> to jump over.
    /// </param>
    /// <param name="humiliatedDogs">
    ///     The wall of shame, a list humiliated dogs and the foxes that have jumped over them.
    /// </param>
    public string JumpOver(IEnumerable<Dog> dogs, IDictionary<Dog, IList<BrownFox>> humiliatedDogs)
    {
        this.jumpSpeed = 15.4f * dogs.Count();
        foreach (Dog dog in dogs)
        {
            dog.Laziness++;
            if (humiliatedDogs.Contains(dog) != true)
            {
                humiliatedDogs.Add(dog, new IList<BrownFox>());
            }
            humiliatedDogs[dog].Add(this);
        }

        string dogNames = string.Join(", ", dogs.Select(a => $"{a.Name} the lazy {a.GetBreed()}"));
        string message = "I, the quick brown fox, jumped over " + dogNames + "  :)";

        return message;
    }
    
    #endregion
}
