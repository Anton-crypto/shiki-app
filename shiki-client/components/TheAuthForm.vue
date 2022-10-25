<template>
    <div>
        <form @submit.prevent="submit">
            <div>
                <label for="email">Email</label>
                <input type="email" id="email" v-model="from.email.value">
            </div>
            <div>
                <label for="password">Пароль</label>
                <input type="text" id="password" v-model="from.password.value">
            </div>
            <button type="submit">Отпварить</button>
        </form>
        {{from}}
    </div>
</template>

<script setup lang="ts">

    import  { useForm } from"@/use/forms"

    const required = (val:any): boolean => { return !!val};

    const from : any = useForm({
        email: {
            value: "email@mail.ru",
            valueDefault: "",
            validators: { required }
        },
        password: {
            value: "1234",
            valueDefault: "",
            validators: { required }
        }
    });

    function submit () {

    }



</script>