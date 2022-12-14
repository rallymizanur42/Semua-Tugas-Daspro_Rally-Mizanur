<template>
    <v-toolbar id="toolbar" color="green darken-4" dark>
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
        <div class="hidden-sm-and-down">
            <v-btn text>Home</v-btn>
            <v-btn text>Profile</v-btn>
            <v-btn text>Unit/Lembaga</v-btn>
            <v-btn text>Akademik</v-btn>
            <v-btn text>Dokumen</v-btn>
            <v-btn text>Gallery</v-btn>
            <v-btn text>Peta</v-btn>
            <v-btn text>Video Profile</v-btn>
            <router-link to="/login">
                <v-btn text>Kontak</v-btn>
            </router-link>
        </div>
        <div class="hidden-sm-and-down">
            <v-navigation-drawer v-mode="drawer" absolute temporary height="800px">
                <v-list class="pa-1">
                    <v-list-item avatar>
                        <v-list-item-avatar>
                            <img src="https://randomuser.me/api/portraits/men/85.jpg">
                        </v-list-item-avatar>
                        <v-list-item-content>
                            <v-list-item-title>Jhon Leider</v-list-item-title>
                        </v-list-item-content>
                    </v-list-item>
                </v-list>
                <v-list class="pt-0" dense nav>
                    <v-divider></v-divider>
                    <v-list-item v-for="item in items" :key="item.title" link>
                        <v-list-item-action>
                            <v-icon>{{ item.icon }}</v-icon>
                        </v-list-item-action>
                        <v-list-item-content>
                            <v-list-item-title>{{item.title}}</v-list-item-title>
                        </v-list-item-content>
                    </v-list-item>
                </v-list>
            </v-navigation-drawer>
        </div>
    </v-toolbar>
</template>

<script>
    export default {
        data () {
            return {
                drawer: null,
                items: [
                    {title:'Home',icon:'mdi-view-dashboard'},
                    {title:'About',icon:'mdi-qustions-answer'}
                ]
            }
        }
    }
</script>

<style>
    #toolbar{
        background-color: darkgreen;
    }
</style>