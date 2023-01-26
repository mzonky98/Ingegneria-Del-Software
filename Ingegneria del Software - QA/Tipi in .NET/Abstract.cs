namespace Ingegneria_del_Software___QA.Tipi_in_.NET
{
    public abstract class Abstract
    {
        protected abstract void Method();
        public abstract int Property
        {
            get;
            set;
        }
        public abstract int this[int index]
        {
            get;
        }
    }
    
    // Sealed stops other classes from overriding the method
    public class AbstractImpl: Abstract
    {
        private int _property;
        
        protected override void Method()
        {
            throw new System.NotImplementedException();
        }

        public override sealed int Property
        {
            get => _property;
            set => _property = value;
        }

        public override int this[int index]
        {
            get => this.GetHashCode();
        }
    }
}
