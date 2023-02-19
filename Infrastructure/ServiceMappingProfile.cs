using AutoMapper;
using DevBoost.Data;
using DevBoost.Models;

namespace DevBoost.Infrastructure
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            //TODO add mappings

            this.CreateMap<Exercise, TaskFormModel>();
            this.CreateMap<Exercise, ExerciseFormModel>();

            //it does the mapping but the task cant be extracted because it is not instanted in exercise.cs
        }
    }
}
