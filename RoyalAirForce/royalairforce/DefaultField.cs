namespace royalairforce
{
    public class DefaultField : Point{
        
        public DefaultField(int x, int y, int z) : base(x, y, z) {
            _fieldType = EFieldType.DEFAULT;
        }
    }
}