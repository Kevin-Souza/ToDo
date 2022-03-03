using ToDo.Models;

namespace ToDo.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar tarefas
                if (!context.Tarefas.Any())
                {
                    context.Tarefas.AddRange(new List<Tarefa>()
                    {
                        new Tarefa()
                        {
                            Name = "Trabalho Asp .Net Core",
                            EndDate = DateTime.Now.AddDays(7),
                            Status = false
                        },
                        new Tarefa()
                        {
                            Name = "Criar banco de dados",
                            EndDate = DateTime.Now.AddDays(5),
                            Status=false
                        },
                        new Tarefa()
                        {
                            Name = "Fazer backup do DB",
                            EndDate= DateTime.Now.AddDays(10),
                            Status=false
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
