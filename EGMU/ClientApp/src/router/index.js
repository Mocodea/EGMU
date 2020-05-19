import Vue from 'vue';
import VueRouter from 'vue-router';
import { vuexOidcCreateRouterMiddleware } from 'vuex-oidc';
import OidcCallback from '@/views/OidcCallback';
import OidcSilentSignIn from '@/views/OidcSilentSignIn';
import Layout from '@/views/Layout.vue';
import Home from '@/views/Home';
import store from '@/store';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Layout',
    component: Layout,
    children: [
      {
        name: 'Home',
        path: '/',
        component: Home,
      },
      {
        path: '/about',
        name: 'About',
        // route level code-splitting
        // this generates a separate chunk (about.[hash].js) for this route
        // which is lazy-loaded when the route is visited.
        component: () =>
          import(/* webpackChunkName: "about" */ '../views/About.vue'),
      },
    ],
  },
  {
    path: '/authentication/login-callback', // Needs to match redirectUri (redirect_uri if you use snake case) in you oidcSettings
    name: 'oidcCallback',
    component: OidcCallback,
  },
  {
    name: 'oidcSilentSignIn',
    path: '/authentication/silent-signin',
    component: OidcSilentSignIn,
    meta: {
      isPublic: true,
    },
  },
];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
});

router.beforeEach(vuexOidcCreateRouterMiddleware(store));

export default router;
