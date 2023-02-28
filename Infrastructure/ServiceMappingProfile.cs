using AutoMapper;
using DevBoost.Data;
using DevBoost.Models.ExerciseModels;

namespace DevBoost.Infrastructure
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            //TODO add mappings

            this.CreateMap<Exercise, TaskFormModel>();
            this.CreateMap<Exercise, ExerciseFormModel>();

        }
    }
}
