export const oidcSettings = {
  authority: 'https://egmu.mocodea.com',
  client_id: 'EGMU',
  redirect_uri: 'https://egmu.mocodea.com/authentication/login-callback',
  response_type: 'code',
  scope: 'EGMUAPI openid profile',
  silentRedirectUri: 'https://egmu.mocodea.com/authentication/silent-signin',
  automaticSilentRenew: true, // If true oidc-client will try to renew your token when it is about to expire
};
