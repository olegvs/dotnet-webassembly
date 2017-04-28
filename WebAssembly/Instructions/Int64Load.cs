namespace WebAssembly.Instructions
{
	/// <summary>
	/// Load 8 bytes as i64.
	/// </summary>
	public class Int64Load : MemoryImmediateInstruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Int64Load"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Int64Load;

		/// <summary>
		/// Creates a new  <see cref="Int64Load"/> instance.
		/// </summary>
		public Int64Load()
		{
		}

		internal Int64Load(Reader reader)
			: base(reader)
		{
		}
	}
}