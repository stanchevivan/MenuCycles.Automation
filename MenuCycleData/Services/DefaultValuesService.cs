using MenuCycleData.Repositories;

namespace MenuCycleData.Services
{

    public class DefaultValues
    {
        public User User { get; set; }
        public Group Group { get; set; }
        public Customer Customer { get; set; }
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
