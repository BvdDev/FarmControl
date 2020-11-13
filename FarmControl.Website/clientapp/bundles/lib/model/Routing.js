import Vue from "vue";
import Home from "ui/Home.vue";
import VueRouter from "vue-router";
Vue.use(VueRouter);
const router = new VueRouter({
    mode: 'hash',
    base: '/FarmControl',
    routes: [
        {
            path: '/',
            redirect: '/home',
            meta: {
                guest: true
            }
        },
        {
            path: '/home',
            component: Home,
            props: true,
            meta: {
                guest: true
            }
        }
    ]
});
export default router;
//# sourceMappingURL=Routing.js.map