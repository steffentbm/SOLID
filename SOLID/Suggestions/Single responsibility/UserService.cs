namespace Suggestions.Single_responsibility
{
    public class UserService
    {
        private EmailService _emailService;
        private UserRepository _userRepository;

		public UserService(EmailService emailService, UserRepository userRepository)
		{
            _emailService = emailService;
            _userRepository = userRepository;
		}
        
        public void Register(User user)
        {
            // Actual business logic: Store user info and send welcome email
            // How the EmailService and UserRepository classes perform these actions will not change this file
            _userRepository.Add(user);
            _emailService.SendWelcomeEmail(user.Email);
        }
    }
}