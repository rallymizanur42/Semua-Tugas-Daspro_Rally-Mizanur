<template>
    <v-footer id="footer" dark height="auto">
        <v-card class="flex" flat tile >
            <v-card-title id="strong" class="green darken-4">
                <strong class="subheading">Get connected with us on social networks!</strong>
                <v-spacer></v-spacer>
                <v-btn v-for="icon in icons" :key="icon" class="mx-3" dark icon>
                    <v-icon size="24px">{{ icon }}</v-icon>
                </v-btn>
            </v-card-title>
            <v-card-actions id="grey" class="grey darken-3 justify-center">©2018 --<strong>Universitas Riau</strong> </v-card-actions>
        </v-card>
    </v-footer >
</template>

<script>


    export default {
        data: () =>({
            icons: [
                'mdi-facebook',
                'mdi-twitter',
                'mdi-google-plus',
                'mdi-linkedin',
                'mdi-instagram',
            ]
        })
    }
</script>

<style>
       #footer{
        position:absolute;
        bottom: 0;
        width:100%;
        background-color: darkgreen;
    }
    #strong {
        background-color: darkgreen;
    }
    #grey {
        justify-content: center;
    }
</style>