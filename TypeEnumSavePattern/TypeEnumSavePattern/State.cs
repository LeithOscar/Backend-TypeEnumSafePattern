namespace EnumTypeSafePattern
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class State
    {
        ///this properties replace the enum.
        public static readonly State Open = new State(1, nameof(Open));
        public static readonly State Closed = new State(2, nameof(Closed));

        public readonly int Id;
        public readonly string Name;

        private State(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        public static IReadOnlyCollection<State> GetAll()
        {
            return new[] { Open, Closed };
        }

        public static State FindbyId(int id)
        {
            var state = GetAll().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                //do something like exception
                state = null;
            }

            return state;
        }
    }
}