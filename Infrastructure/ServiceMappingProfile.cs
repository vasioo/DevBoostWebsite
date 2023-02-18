using AutoMapper;
using DevBoost.Data;
using DevBoost.Models;

namespace DevBoost.Infrastructure
{
    public class ServiceMappingProfile:Profile
    {
        public ServiceMappingProfile()
        {
            //TODO add mappings

            this.CreateMap<Exercise, ExerciseFormModel>();
        }
    }
}
