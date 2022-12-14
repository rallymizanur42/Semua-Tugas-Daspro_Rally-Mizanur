<template>
    <v-container>
        <v-form v-model="valid">
            <v-text-field v-model="name" :rules="nameRules" :counter="10" label="Name" required></v-text-field>
            <v-text-filed v-model="email" :rules="emailrules" label="E-email" required></v-text-filed>
            <v-text-filed v-model="pesan" label="Pesan" multi-line></v-text-filed>
        </v-form>
    </v-container>
</template>

<script>
    export default {
        data: () => ({
            valid: false,
            name:'',
            nameRules: [
                v => !!v|| 'Name is required',
                v => v.length <= 10 || 'Name must be less than 10 character'
            ],
            email:'',
            emailRules: [
                v => !!v || 'E-mail is required',
                v => /.+@.+/.test(v) || 'E-mail must be valid'
            ],
            pesan:''
        })
    }
</script>