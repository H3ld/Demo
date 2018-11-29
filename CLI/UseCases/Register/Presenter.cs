using Demo.Application.UseCases.Register;
using Demo.Domain.Tasks;
using System.Collections.Generic;

namespace CLI.UseCases.Register
{
	public class Presenter
	{
		public string Name { get; set; }
		public IReadOnlyCollection<Todo> AssociatedTodos { get; set; }

		public Presenter(RegisterOutput output)
		{
			AssociatedTodos = output.UserOutput.AssociatedTodos.GetReadOnly();
			Name = (string)output.UserOutput.Name;
		}
	}
}