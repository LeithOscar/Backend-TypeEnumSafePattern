
namespace TypeEnumSavePattern
{
    using EnumTypeSafePattern;
    public class Foro
    {

        public string Name;
        public ForoState StateEnum;
        public State StateSealead;

        public Foro(string name)
        {
            this.Name = name;
            this.StateEnum = ForoState.Open;
        }
        /// <summary>
        /// Changes the state.Example using Enum
        /// </summary>
        /// <param name="foroState">Foro state.</param>
        public void ChangeState(ForoState foroState)
        {
            this.StateEnum = foroState;
        }

        /// <summary>
        /// Changes the state. Example usign sealead class
        /// </summary>
        /// <param name="state">State.</param>
        public void ChangeState(State state)
        {
            this.StateSealead = state;
        }
    }
}

