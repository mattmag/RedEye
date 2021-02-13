/// <summary>
///     Monitors user input for easy digestion.
/// </summary>
public class InputMonitor
{
    /// <summary>
    ///     The state of things during the previous <see cref="Update"/>
    /// </summary>
    private InputState last = new InputState();

    /// <summary>
    ///     The state of things during this update
    /// </summary>
    private InputState current = new InputState();

    /// <summary>
    ///     Used to acquire the current state of all user input methods.
    /// </summary>
    private readonly IInputProvider inputProvider;


    /// <summary>
    ///     Initializes a new InputMonitor instance.
    /// </summary>
    /// <param name="inputProvider">
    ///     The <see cref="IInputProvider"/> instance to use.
    /// </param>
    public InputMonitor(IInputProvider inputProvider)
    {
        this.inputProvider = inputProvider;
    }

    /// <summary>
    ///     Update the current state of user input
    /// </summary>
    public void Update()
    {
        this.last = this.current;
        this.current = this.inputProvider.CurrentInputState();
    }

    /// <summary>
    ///     Check to see if the buttons or key abstracted by this mapping are currently pressed.
    /// </summary>
    /// <param name="mapping">
    ///     The button mapping definition.
    /// </param>
    /// <returns>
    ///     True if either the game pad button or key is currently pressed.
    /// </returns>
    public Boolean IsPressed(DiscreteInputMapping mapping)
    {
        return IsPressed(mapping, this.current);
    }

    /// <summary>
    ///     Check to see if the button or key abstracted by this mapping are currently pressed,
    ///     but were not pressed during the last update.
    /// </summary>
    /// <param name="mapping">
    ///     The button mapping definition.
    /// </param>
    /// <returns>
    ///     True if the button or key is pressed now but neither was pressed before.
    /// </returns>
    public Boolean IsNewlyPressed(DiscreteInputMapping mapping)
    {
        return IsPressed(mapping, this.current) && !IsPressed(mapping, this.last);
    }

    /// <summary>
    ///     Check to see if the button or key abstracted by this mapping is currently released
    ///     but was pressed during the last update.
    /// </summary>
    /// <param name="mapping">
    ///     The button mapping definition.
    /// </param>
    /// <returns>
    ///     True if the button or key is released now but either was pressed before.
    /// </returns>
    public Boolean IsNewlyReleased(DiscreteInputMapping mapping)
    {
        return !IsPressed(mapping, this.current) && IsPressed(mapping, this.last);
    }

    /// <summary>
    ///     Get the current mmouse location as a vector.
    /// </summary>
    /// <returns>
    ///     A vector representing the location of the mouse within the game window.
    /// </returns>
    public Vector2 MousePosition()
    {
        return this.current.Mouse.Position.ToVector2();
    }

    /// <summary>
    ///     Get a vector representing the change in mouse position from the last update.
    /// </summary>
    /// <returns>
    ///     A vector representing the change in mouse position from the last update.
    /// </returns>
    public Vector2 MouseDelta()
    {
        return this.current.Mouse.Position.ToVector2() - this.last.Mouse.Position.ToVector2();
    }

    /// <summary>
    ///     Lazily iterate through a mapping's possible values checking if each is pressed
    /// </summary>
    /// <param name="mapping">
    ///     The button mapping definition.
    /// </param>
    /// <param name="state">
    ///     The input state to check
    /// </param>
    private IEnumerable<Option<Boolean>> IterateMapping(DiscreteInputMapping mapping, InputState state)
    {
        yield return mapping.GamepadButton.Map(a => state.GamePad.IsButtonDown(a));
        yield return mapping.Key.Map(a => state.Keyboard.IsKeyDown(a));
        yield return mapping.Mouse.Map(a => IsMousePressed(a, state));
    }
    

    private Boolean IsPressed(DiscreteInputMapping mapping, InputState state)
    {
        return IterateMapping(mapping, state).Values().Any(a => a == true);
    }
    
    private bool IsMousePressed(MouseButtons button, InputState state)
    {
        switch (button)
        {
            case MouseButtons.Left:
                return state.Mouse.LeftButton == ButtonState.Pressed;
            case MouseButtons.Right:
                return state.Mouse.RightButton == ButtonState.Pressed;
            case MouseButtons.Middle:
                return state.Mouse.MiddleButton == ButtonState.Pressed;
            case MouseButtons.X1:
                return state.Mouse.XButton1 == ButtonState.Pressed;
            case MouseButtons.X2:
                return state.Mouse.XButton2 == ButtonState.Pressed;
            default:
                return false;
        }
    }
}
