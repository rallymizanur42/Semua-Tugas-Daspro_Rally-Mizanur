import Vue from 'vue'
import VueRouter from 'vue-router'
import HomeView from '../views/HomeView.vue'
import WebLogin from '../components/WebLogin.vue'



Vue.use(VueRouter)

const routes = [{
        path: '/',
        name: 'home',
        component: HomeView
    },
    {
        path: '/about',
        name: 'about',

        component: () =>
            import ('../views/AboutView.vue')
    },
    {
        path:'./login',
        name:'login',
        component: WebLogin
    }
]

const router = new VueRouter({
    routes
})

export default router