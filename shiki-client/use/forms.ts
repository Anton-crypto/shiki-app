import { ref, reactive, watch } from "vue"

function useForm(init: Object = {}) {
    const form = reactive({})

    for(const [key, value] of Object.entries(init)) {
        form[key] = useField(value);
    }

    return form;
}

function useField(field : any) {

    const valid = ref(true);
    const value = ref(field.value);
    const errors = reactive({});

    const reassign = val => {
        Object.keys(field.validators ?? {}).map(name => {
            const isValid = field.validators[name](val);
            errors[name] = !isValid;
        })
    }

    watch(value, reassign);
    reassign(value.value);

    return {
        valid, 
        value,
        errors,
    }
}

export  { 
    useForm,
} 