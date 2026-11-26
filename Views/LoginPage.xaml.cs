namespace Ex_labs.Views;

public partial class LoginPage : ContentPage
{
    private string _selectedRole = "Patient";

    public LoginPage()
    {
        InitializeComponent();
        UpdateRoleVisualState();
    }

    private void OnSelectPatientClicked(object sender, EventArgs e)
    {
        _selectedRole = "Patient";
        UpdateRoleVisualState();
    }

    private void OnSelectWorkerClicked(object sender, EventArgs e)
    {
        _selectedRole = "Worker";
        UpdateRoleVisualState();
    }

    private void UpdateRoleVisualState()
    {
        bool isPatient = _selectedRole == "Patient";

        BtnRolePatient.BackgroundColor = isPatient ? Color.FromArgb("#008FB8") : Color.FromArgb("#E6F2F7");
        BtnRolePatient.TextColor = isPatient ? Colors.White : Color.FromArgb("#006B8F");

        BtnRoleWorker.BackgroundColor = !isPatient ? Color.FromArgb("#008FB8") : Color.FromArgb("#E6F2F7");
        BtnRoleWorker.TextColor = !isPatient ? Colors.White : Color.FromArgb("#006B8F");
    }

    private void OnTogglePasswordClicked(object sender, EventArgs e)
    {
        PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        BtnTogglePassword.Text = PasswordEntry.IsPassword ? "Ver" : "Ocultar";
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        ErrorLabel.IsVisible = false;

        string email = EmailEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            ShowError("Por favor ingresa tu correo/usuario y contraseña.");
            return;
        }

        SetLoading(true);

        try
        {
            // Aquí irá tu llamada real al servicio de autenticación / API
            await Task.Delay(500);

            if (_selectedRole == "Worker")
            {
                await DisplayAlert("Acceso Trabajador", $"Bienvenido al panel de personal: {email}", "Continuar");
                // Navegación hacia la vista de trabajadores
            }
            else
            {
                await DisplayAlert("Acceso Paciente", $"Bienvenido a Ex-labs: {email}", "Continuar");
                // Navegación hacia la vista de pacientes
            }
        }
        catch (Exception ex)
        {
            ShowError($"No se pudo iniciar sesión: {ex.Message}");
        }
        finally
        {
            SetLoading(false);
        }
    }

    private void ShowError(string message)
    {
        ErrorLabel.Text = message;
        ErrorLabel.IsVisible = true;
    }

    private void SetLoading(bool isLoading)
    {
        LoadingIndicator.IsVisible = isLoading;
        LoadingIndicator.IsRunning = isLoading;
        BtnLogin.IsEnabled = !isLoading;
        BtnRolePatient.IsEnabled = !isLoading;
        BtnRoleWorker.IsEnabled = !isLoading;
    }
}
