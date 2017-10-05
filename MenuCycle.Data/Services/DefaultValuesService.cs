using MenuCycle.Data.Repositories;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Services
{

    public class DefaultValues
    {
        public Users User { get; set; }
        public Groups Group { get; set; }
        public Customers Customer { get; set; }
    }

    public class DefaultValuesService
    {
        private readonly UserRepository userRepository;
        private readonly CustomerRepository customerRepository;
        private readonly GroupRepository groupRepository;

        public DefaultValuesService(UserRepository userRepository, CustomerRepository customerRepository, GroupRepository groupRepository)
        {
            this.userRepository = userRepository;
            this.customerRepository = customerRepository;
            this.groupRepository = groupRepository;
        }

        public DefaultValues GetDefaults(int userId, int customerId, string groupName)
        {
            return new DefaultValues
            {
                Customer = this.customerRepository.FindById(customerId),
                Group = this.groupRepository.FindByName(groupName),
                User = this.userRepository.FindById(userId)
            };
        }
    }
}
