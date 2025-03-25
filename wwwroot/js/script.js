

const container = document.querySelector('.container');
const regesterbtn = document.querySelector('.btn-register');
const loginbtn = document.querySelector('.btn-login');


regesterbtn.addEventListener('click',() => {
    container.classList.add('active');
})
loginbtn.addEventListener('click',() => {
    container.classList.remove('active');
})

const userType = document.getElementById('userType');
const extraFields = document.getElementById('extra-fields');

userType.addEventListener('change', () => {
    extraFields.innerHTML = ''; // تفريغ الحقول الإضافية عند التغيير
    const selectedType = userType.value;

    if (selectedType === 'admin') {
        extraFields.innerHTML = `
            <div class="input-box">
                <input type="text" class="input" placeholder="Admin Code" required>
                <i class='bx bx-code'></i>
                </div>
        `;
    } else if (selectedType === 'user') {
        extraFields.innerHTML = `
            <div class="input-box">
                <input type="number" class="input" placeholder="Age" required>
            </div>
            <div class="input-box">
                <select class="input" required>
                    <option value="">Select Gender</option>
                    <option value="male">Male <i class='bx bx-male' ></i></option>
                    <option value="female">Female <i class='bx bx-female' ></i></option>
                    <option value="other">Other</option>
                </select>
            </div>
        `;
    } else if (selectedType === 'Psychologist') {
        extraFields.innerHTML = `
            <div class="input-box">
                <input type="text" class="input" placeholder="Specialization" required>
            </div>
            <div class="input-box">
                <input type="number" class="input" placeholder="Years of Experience" required>

                </div>
        `;
    }
});